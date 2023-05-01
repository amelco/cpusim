- Versão em [português](README.pt-br.md)

# CpuSim
A basic Intel 8086 CPU simulator.

Based on **Computer, Enhance!** course by Casey Muratori and documentation for [Intel 8086 chip](https://edge.edx.org/c4x/BITSPilani/EEE231/asset/8086_family_Users_Manual_1_.pdf).

Each commit will be a new lesson. So the first commit will be lesson 1.
The idea is to create code for each lesson and put it here as a way of documenting my progress and,
at the same time serving as a code repository.
It also lets you follow my thinking by getting the differences between commits.

I'll try to do everything from documentation to code comments in both English and Portuguese.

### How to run
Clone the repository and run it in Visual Studio or any other preferred editor/IDE.
It is a simple dotnet 6 console application.

### How to use
Once compiled, just type `cpusim` to show the usage message (which can be different for each commit) and read the instructions.

## 1st Lesson: Instruction Decoding on the 8086
In this lesson, we will learn how to decode 8086 CPU instructions.
We will use the following instructions:
`MOV` record for record.

It's one of the simplest instructions to decode, making it a good introduction to how the CPU works.

The objective of this lesson is to create a program that reads a file with binary instructions in 8086 assembly,
decode the `MOV` instruction and print the result to the screen. For this we have two input files
```
single_register_mov
many_register_mov
```
which contains binary code with one and several `MOV` instructions, respectively.

Below is the binary code of `single_register_mov`. Note that it's only 2 bytes long.

![](https://github.com/amelco/cpusim/blob/main/images/L1-3.PNG)

The program receives as the first input parameter the name of the file to be read and prints the
screen decoding. The figure below shows an example of running the program.

![Example of running program](https://github.com/amelco/cpusim/blob/main/images/L1-1.PNG)

**Note**: You can optionally run debug mode for more information
about what is going on, such as the values being temporarily read from the file.

![Example of showing debug information](https://github.com/amelco/cpusim/blob/main/images/L1-2.PNG)

The respective `.asm` extension files contain the 8086 assembly code that generated the input files.
Therefore, the output result of the program must be the same as the `.asm` file.

**Interesting fact**: It is possible to binary output the program using the command `nasm filename.asm`
(click [here](https://www.nasm.us/) to download nasm).
The generated binary can be compared with the input file to verify that the program is correct.
On windows, to compare two binary files, just use the command `fc file1 file2`.

Link to code: [Lesson 1](https://github.com/amelco/cpusim/commit/cb10100c4bbd553a723317b0c8ace3d556677f5d).
