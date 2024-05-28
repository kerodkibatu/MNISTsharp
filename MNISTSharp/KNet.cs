// Net.cs
using System;
using TorchSharp;
using TorchSharp.Modules;
using static TorchSharp.torch;
using static TorchSharp.torch.nn;
using static TorchSharp.torch.nn.functional;

public class KNet : Module
{
    private Conv2d conv1;
    private Conv2d conv2;
    private Linear fc1;
    private Linear fc2;
    private Linear fc3;

    public KNet() : base("Net")
    {
        conv1 = Conv2d(1, 6, 5);
        conv2 = Conv2d(6, 16, 5);
        fc1 = Linear(16 * 4 * 4, 120);
        fc2 = Linear(120, 84);
        fc3 = Linear(84, 10);

        RegisterComponents();
    }

    public Tensor forward(Tensor input,bool applySoftmax = true)
    {
        input = relu(max_pool2d(conv1.forward(input), 2));
        input = relu(max_pool2d(conv2.forward(input), 2));
        input = input.view(-1, 16 * 4 * 4);
        input = relu(fc1.forward(input));
        input = relu(fc2.forward(input));
        input = fc3.forward(input);
        if (applySoftmax)
            return log_softmax(input, 1);
        else
            return input;
    }
}