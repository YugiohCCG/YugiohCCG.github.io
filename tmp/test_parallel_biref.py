import time
from concurrent.futures import ProcessPoolExecutor
from PIL import Image
import onnxruntime as ort
import rembg

holo_dir = r"C:\Program Files (x86)\YGO Omega\YGO Omega_Data\Files\Holograms"
sample = ["211682274.png", "211699737.png", "211873618.png", "211964444.png"]

def worker_task(name):
    opts = ort.SessionOptions()
    opts.intra_op_num_threads = 4
    s = rembg.new_session("birefnet-general", session_options=opts)
    img = Image.open(f"{holo_dir}\\{name}")
    out = rembg.remove(img, session=s)
    return name, out.size

if __name__ == "__main__":
    t0 = time.time()
    with ProcessPoolExecutor(max_workers=2) as executor:
        results = list(executor.map(worker_task, sample))
    dt = time.time() - t0
    print(f"2 processes (4 threads each): {dt:.2f}s for 4 images ({dt/4:.2f}s/image)")
