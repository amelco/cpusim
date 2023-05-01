- English [version](Readme.md)

# CpuSim
Um simulador básico de CPU Intel 8086.

Baseado no curso **Computer, Enhance!** de Casey Muratori e na documentação do [chip 8086 da Intel](https://edge.edx.org/c4x/BITSPilani/EEE231/asset/8086_family_Users_Manual_1_.pdf).

Cada commit será uma nova lição. Assim, o primeiro commit será a lição 1.
A ideia é criar o código para cada lição e colocá-lo aqui como forma de documentar meu progresso e,
ao mesmo tempo, servir como um repositório de código.
Isso também permite acompanhar meu modo de pensar, obtendo as diferenças entre os commits.

Eu vou tentar fazer tudo, desde a documentação até os comentários de código, tanto em inglês quanto em português.

### Como executar
Clone o repositório e execute-o no Visual Studio ou em qualquer outro editor/IDE de preferência.
É uma aplicação de console simples do dotnet 6.

### Como usar
Uma vez compilado, basta digitar `cpusim` para mostrar a mensagem de uso (que pode ser diferente para cada commit) e ler as instruções.

## 1ª Lição: Decodificação de Instruções no 8086
Nesta lição, aprenderemos como decodificar as instruções da CPU 8086.
Usaremos as seguintes instruções:
`MOV` registro para registro.

É uma das instruções mais simples de decodificar, tornando-a uma boa introdução sobre como a CPU funciona.

O objetivo dessa lição é criar um programa que leia um arquivo com instruções binárias em assembly 8086,
decodifique a instrução `MOV` e imprima o resultado na tela. Para isso, temos dois arquivos de entrada
```
single_register_mov
many_register_mov
```
que contém o código binário com uma e várias instruções `MOV`, respectivamente.

Abaixo, o código binário de `single_register_mov`. Note que são apenas 2 bytes.

![](https://github.com/amelco/cpusim/blob/main/images/L1-3.PNG)

O programa recebe como primeiro parâmetro de entrada o nome do arquivo a ser lido e imprime a
decodificação na tela. A figura abaixo mostra um exemplo de execução do programa.

![](https://github.com/amelco/cpusim/blob/main/images/L1-1.PNG)

**Observação**: você pode , opcionalmente, executar o modo de debug para obter mais informações
sobre o que está acontecendo, como os valores que estão sendo temporiariamente lidos do arquivo.

![](https://github.com/amelco/cpusim/blob/main/images/L1-2.PNG)

Os respectivos arquivos de extensão `.asm` contém o código assembly 8086 que gerou os arquivos de entrada.
Portanto, o resultado da saída do programa deve ser igual ao do arquivo `.asm`.

**Fato interessante**: é possível gerar o binário da saída do programa usando o comando `nasm nome_do_arquivo.asm`
(clique [aqui](https://www.nasm.us/) pra baixar o nasm).
O binário gerado pode ser comparado com o arquivo de entrada para verificar se o programa está correto.
No windows, para comparar dois arquivos binários, basta usar o comando `fc arquivo1 arquivo2`.

Link para o código: [Lição 1](https://github.com/amelco/cpusim/commit/cb10100c4bbd553a723317b0c8ace3d556677f5d).

## 2ª Aula: Decodificando Múltiplas Instruções e Sufixos
Nesta lição, aprenderemos como decodificar mais instruções e sufixos. Vamos começar a implementar o
Instrução **immediate to register**.
Esta instrução é usada para mover um valor diretamente para um registrador.

Um arquivo chamado `single_immediate.asm` contém o código assembly para esta instrução.
Gere o arquivo binário (`nasm single_immediate.asm`) e execute o programa com a saída nasm como entrada do programa:
`cpusim single_immediate`.
Você também pode executar o programa no modo de depuração (`cpusim single_immediate debug`) para ver os valores sendo lidos do arquivo.