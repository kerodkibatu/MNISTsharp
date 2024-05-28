using TorchSharp;
var device = torch.cuda_is_available() ? torch.CUDA : torch.CPU;
var transform = torchvision.transforms.Compose(
    torchvision.transforms.Normalize(means: [0.1307],stdevs: [0.3081])
);

var trainset = torchvision.datasets.MNIST("./", true, target_transform: transform);
var testset = torchvision.datasets.MNIST("./", false, target_transform: transform);

var trainloader = torch.utils.data.DataLoader(trainset, 64, true);
var testloader = torch.utils.data.DataLoader(testset, 64, true);

var net = new KNet();
var criterion = torch.nn.NLLLoss();
var optimizer = torch.optim.AdamW(net.parameters());

//time the training
string loadPath = "KNET.dat";
//if loadPath is not null and exists, load the model
if (!string.IsNullOrEmpty(loadPath) && File.Exists(loadPath))
{
    net.load(loadPath);
    net = net.to(device);
    Console.WriteLine("Model loaded");
}
else
{
    var sw = System.Diagnostics.Stopwatch.StartNew();

    for (int epoch = 1; epoch <= 10; epoch++)
    {
        float running_loss = 0.0f;
        foreach (var data in trainloader)
        {
            var inputs = data["data"].to(device);
            var labels = data["label"].to(device);

            optimizer.zero_grad();
            var outputs = net.forward(inputs);
            var loss = criterion.call(outputs, labels);
            loss.backward();
            optimizer.step();

            running_loss += loss.item<float>();
        }
        Console.WriteLine($"Epoch {epoch} loss: {running_loss / trainloader.Count}");
    }
    var el = sw.Elapsed;
    Console.WriteLine($"Finished Training [{el.Minutes}:{el.Seconds}.{el.Milliseconds}]");
    net.save("KNET.dat");
}

var correct = 0L;
var total = 0L;
foreach (var data in testloader)
{
    var inputs = data["data"].to(device);
    var labels = data["label"].to(device);
    var outputs = net.forward(inputs);
    (_, var predicted) = torch.max(outputs, 1);
    total += labels.size(0);
    correct += (predicted == labels).sum().item<long>();
}

Console.WriteLine($"Accuracy of the network on the 10000 test images: {100 * (float)correct / total}%");