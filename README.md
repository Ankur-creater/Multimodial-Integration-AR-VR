# Multimodal Integration AR-VR

## Project Overview
This project integrates **Augmented Reality (AR) and Virtual Reality (VR)** technologies for multimodal interaction and visualization. It utilizes **Unity** with various packages to achieve high-performance rendering and simulation.

## Missing Large Files
Due to **GitHub's file size limitations**, two large files are not included in the repository. Follow these steps to manually download and place them in the correct locations:

### **1. Download the Required Files**
- **File 1:** [Download libburst-llvm-16.dylib](https://drive.google.com/file/d/1h62B8JpLz8ESx5xV7Qx8--wTtnBEB4yi/view?usp=drive_link)
- **File 2:** [Download ArtifactDB](https://drive.google.com/file/d/1TIrYRu2lxYif0csqHxibsExyV963XhN3/view?usp=drive_link)

### **2. Paste the Files in the Following Locations**
- **libburst-llvm-16.dylib** → Paste into:  
  ```
  C:\...\Multimodial-Integration-AR-VR\PackageCache\com.unity.burst\.Runtime\
  ```
- **ArtifactDB** → Paste into:  
  ```
  C:........\Multimodial-Integration-AR-VR\Library1\
  ```

## Additional Cleanup Steps
To keep the project organized, remove **one file each** from the following directories:
- **Logs**
- **Library**
- **User Setting**

## Setup Instructions
1. Clone the repository:
   ```bash
   git clone https://github.com/your-repo/Multimodal-Integration-AR-VR.git
   ```
2. Follow the **missing files download** instructions above.
3. Open the project in **Unity 6**.
4. Ensure all required dependencies are installed.
5. Run the project and test AR/VR functionality.

## Contributing
Feel free to submit **pull requests** for bug fixes, optimizations, or new features.

## License
This project is licensed under the **MIT License**.
