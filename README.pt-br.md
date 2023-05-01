- English [version](Readme.md)

# CpuSim
Um simulador b�sico de CPU Intel 8086.

Baseado no curso **Computer, Enhance!** de Casey Muratori e na documenta��o do [chip 8086 da Intel](https://edge.edx.org/c4x/BITSPilani/EEE231/asset/8086_family_Users_Manual_1_.pdf).

Cada commit ser� uma nova li��o. Assim, o primeiro commit ser� a li��o 1.
A ideia � criar o c�digo para cada li��o e coloc�-lo aqui como forma de documentar meu progresso e,
ao mesmo tempo, servir como um reposit�rio de c�digo.
Isso tamb�m permite acompanhar meu modo de pensar, obtendo as diferen�as entre os commits.

Eu vou tentar fazer tudo, desde a documenta��o at� os coment�rios de c�digo, tanto em ingl�s quanto em portugu�s.

### Como executar
Clone o reposit�rio e execute-o no Visual Studio ou em qualquer outro editor/IDE de prefer�ncia.
� uma aplica��o de console simples do dotnet 6.

### Como usar
Uma vez compilado, basta digitar `cpusim` para mostrar a mensagem de uso (que pode ser diferente para cada commit) e ler as instru��es.

## 1� Li��o: Decodifica��o de Instru��es no 8086
Nesta li��o, aprenderemos como decodificar as instru��es da CPU 8086.
Usaremos as seguintes instru��es:
`MOV` registro para registro.

� uma das instru��es mais simples de decodificar, tornando-a uma boa introdu��o sobre como a CPU funciona.

O objetivo dessa li��o � criar um programa que leia um arquivo com instru��es bin�rias em assembly 8086,
decodifique a instru��o `MOV` e imprima o resultado na tela. Para isso, temos dois arquivos de entrada
```
single_register_mov
many_register_mov
```
que cont�m o c�digo bin�rio com uma e v�rias instru��es `MOV`, respectivamente.

Abaixo, o c�digo bin�rio de `single_register_mov`. Note que s�o apenas 2 bytes.

![](https://github.com/amelco/cpusim/blob/main/images/L1-3.PNG)

O programa recebe como primeiro par�metro de entrada o nome do arquivo a ser lido e imprime a
decodifica��o na tela. A figura abaixo mostra um exemplo de execu��o do programa.

![](https://github.com/amelco/cpusim/blob/main/images/L1-1.PNG)

**Observa��o**: voc� pode , opcionalmente, executar o modo de debug para obter mais informa��es
sobre o que est� acontecendo, como os valores que est�o sendo temporiariamente lidos do arquivo.

![](https://github.com/amelco/cpusim/blob/main/images/L1-2.PNG)

Os respectivos arquivos de extens�o `.asm` cont�m o c�digo assembly 8086 que gerou os arquivos de entrada.
Portanto, o resultado da sa�da do programa deve ser igual ao do arquivo `.asm`.

**Fato interessante**: � poss�vel gerar o bin�rio da sa�da do programa usando o comando `nasm nome_do_arquivo.asm`
(clique [aqui](https://www.nasm.us/) pra baixar o nasm).
O bin�rio gerado pode ser comparado com o arquivo de entrada para verificar se o programa est� correto.
No windows, para comparar dois arquivos bin�rios, basta usar o comando `fc arquivo1 arquivo2`.

Link para o c�digo: [Li��o 1](https://github.com/amelco/cpusim/commit/cb10100c4bbd553a723317b0c8ace3d556677f5d).

## 2� Aula: Decodificando M�ltiplas Instru��es e Sufixos
Nesta li��o, aprenderemos como decodificar mais instru��es e sufixos. Vamos come�ar a implementar o
Instru��o **immediate to register**.
Esta instru��o � usada para mover um valor diretamente para um registrador.

Um arquivo chamado `single_immediate.asm` cont�m o c�digo assembly para esta instru��o.
Gere o arquivo bin�rio (`nasm single_immediate.asm`) e execute o programa com a sa�da nasm como entrada do programa:
`cpusim single_immediate`.
Voc� tamb�m pode executar o programa no modo de depura��o (`cpusim single_immediate debug`) para ver os valores sendo lidos do arquivo.