- English version:  [README.md](README.md)

# CpuSim
Um simulador b�sico de CPU Intel 8086.

Baseado no curso **Computer, Enhance!** de Casey Muratori.

Cada commit ser� uma nova li��o. Assim, o primeiro commit ser� a li��o 1.
A ideia � criar o c�digo para cada li��o e coloc�-lo aqui como forma de documentar meu progresso e,
ao mesmo tempo, servir como um reposit�rio de c�digo.
Isso tamb�m permite acompanhar meu modo de pensar, obtendo as diferen�as entre os commits.

Eu vou tentar fazer tudo, desde a documenta��o at� os coment�rios de c�digo, tanto em ingl�s quanto em portugu�s.

### Como executar
Clone o reposit�rio e execute-o no Visual Studio ou em qualquer outro editor/IDE de prefer�ncia.
� uma aplica��o de console simples do dotnet 6.

### Como usar
Uma vez compilado, basta digitar cpusim para mostrar a mensagem de uso (que pode ser diferente para cada commit) e ler as instru��es.

## 1� Li��o: Decodifica��o de Instru��es no 8086
Nesta li��o, aprenderemos como decodificar as instru��es da CPU 8086.
Usaremos as seguintes instru��es:
`MOV` registro para registro.

� uma das instru��es mais simples de decodificar, tornando-a uma boa introdu��o sobre como a CPU funciona.

Link para o c�digo: [Li��o 1](https://github.com/amelco/cpusim/commit/cb10100c4bbd553a723317b0c8ace3d556677f5d).