
# DIO - .NET Trail - Object Oriented Programming
[Digital Innovation One](https://www.dio.me/?ref=RE6NDV822B)

## Design Challenge 🚧
For this challenge I needed to use the knowledge acquired in the object-oriented module, from DIO's .NET track.

## Context 📞
In this challenge I am responsible for modeling a system that works with cell phones. For this, I was asked to make an abstraction of a cell phone and provide ways for different brands and models to have their own behavior, allowing greater code reuse and using object orientation.

## Proposal 📴
I needed to create a system in .NET, console type, mapping an abstract class and specific classes for two types of cell phones: Nokia and iPhone.
At first I created the classes according to the diagram below:

![Class diagram](Imagem/diagrama.png)

## Rules and validations 📋
1. The **Smartphone** class must be abstract, not allowing instantiation and serving only as a model.
2. Class **Nokia** and **Iphone** must be child classes of Smartphone.
3. The **InstalarAplicativo** method must be overridden in the Nokia and iPhone class, as they both have different ways of installing an application.

## Solution 📲
The code was half finished, and I had to continue following the rules described above, so that in the end, there was a working program.

## Increment++ 🎓💡
 - In addition to the "Nokia" and "Iphone" classes, I created the "Motorola" class;
 - In addition to the "Ligar()" and "ReceberLigacao()" methods, the "Desligar()" and "RecusarLigacao()" methods were created.
 
 
 
 [Certificate: 📜](https://www.dio.me/certificate/E8F8A44C/share)
