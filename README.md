# **MNISTsharp: A Pure C# End-to-End Deep Learning Demo using Torchsharp**

This repository provides a comprehensive demonstration of deep learning capabilities in pure C# using the Torchsharp library, along with an interactive inference demo utilizing Winforms UI.

# **Overview**

The MNISTsharp project showcases the power of deep learning in C# by implementing a neural network from scratch, leveraging the Torchsharp library for efficient and accurate computations. The repository includes:

1. **MNIST Classification Model**: A deep convolutional neural network that classifies handwritten digits (0-9) using the MNIST dataset achieving over 98.5% accuracy.

![image](https://github.com/kerodkibatu/MNISTsharp/assets/88666160/5d45d922-466f-4a2b-8515-ac9157f44d47)

2. **Winforms UI Inference Demo**: An interactive demo allowing users to input handwritten digits, which are then classified by the trained model and displayed in real-time.

![image](https://github.com/kerodkibatu/MNISTsharp/assets/88666160/969dbb76-e9ec-45de-b6de-d2c4367915a9)

# **Features**

* **Pure C# Implementation**: No reliance on external dependencies or languages; all code is written in C#.
* **Torchsharp Integration**: Utilizes Torchsharp for efficient neural network operations.
* **Winforms UI Demo**: Interactive demonstration of the trained model's inference capabilities.
* **MNIST Dataset Included**: Includes preprocessed MNIST dataset for training and testing.

# **Getting Started**

1. Clone this repository: `git clone https://github.com/username/MNISTsharp.git`
2. Open the solution in Visual Studio (2019 or later): `MNISTSharp.sln`
3. Build the project: Right-click on the solution -> `Build` -> `Rebuild Solution`
4. Run the demo: Right-click on the `KNET_Inference` project -> `Debug` -> `Start Debugging`

# **Requirements**

* Visual Studio 2019 or later
* .NET 8 SDK
* Torchsharp library

# **Contributions**

This repository is open to contributions! If you'd like to contribute, please create a pull request with your changes and provide a brief description of the updates.

# **Acknowledgments**

The MNIST dataset was obtained from the Yann LeCun's website (http://yann.lecun.com/exdb/mnist/). Torchsharp is an open-source library developed by Microsoft Research.

# **License**

This project is licensed under the MIT License. See [`LICENSE`](LICENSE.txt) for details.
