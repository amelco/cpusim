- Versão em Português: [README.pt-br.md](README.pt-br.md)

# CpuSsim
A basic Intel 8086 CPU simulator.

Based on the course **Computer, Enhance!** by Casey Muratori. 

Every commit will be a new lesson. So the first, commit will be lesson 1.
The idea is to make the code for every lesson and put it here as a form of documenting my progress and,
at the same time, to serve as a code repository.
It also allow to follow my way of thinking by getting the differences between commits.

I will try to make everything, from documentation to code comments, both in english and portuguese.

### How to run
Clone the repo and run it in Visual Studio or any other editor/IDE of preference.
It is simple dotnet 6 console application.

### How to use it
Once compiled, simply type `cpusim` to show the usage message (it can be different for each commit) and read the instructions.

## 1st Lesson: Instruction Decoding on the 8086
In this lesson we will learn how to decode the instructions of the 8086 CPU. 
We will use the following instructions:
`MOV` register to register.

It is one of the simplest instructions to decode, making it a good introduction on how the CPU works.

The goal of this lesson is to create a program that reads a file with binary instructions in 8086 assembly,
decodes the MOV instruction, and prints the result on the screen. To do this, we have two input files:
```
single_register_mov
many_register_mov
```
which contain the binary code with one and several `MOV` instructions, respectively.

The program takes the name of the file to be read as the first input parameter and prints the decoding on the screen.

The respective files with the `.asm` extension contain the 8086 assembly code that generated the input files. 
Therefore, the output of the program should be the same as the `.asm` file.

**Interesting fact**: it is possible to generate the output binary of the program using the command `nasm file_name.asm` 
(click [here](https://www.nasm.us/) to download nasm). The generated binary can be compared to the input file to verify if the program is correct. 
In Windows, to compare two binary files, simply use the command `fc file1 file2`.

Link for the code: [Lesson 1](https://github.com/amelco/cpusim/commit/cb10100c4bbd553a723317b0c8ace3d556677f5d).
