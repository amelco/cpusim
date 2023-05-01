- English version:  [README.md](README.md)

# CpuSim
Um simulador básico de CPU Intel 8086.

Baseado no curso **Computer, Enhance!** de Casey Muratori.

Cada commit será uma nova lição. Assim, o primeiro commit será a lição 1.
A ideia é criar o código para cada lição e colocá-lo aqui como forma de documentar meu progresso e,
ao mesmo tempo, servir como um repositório de código.
Isso também permite acompanhar meu modo de pensar, obtendo as diferenças entre os commits.

Eu vou tentar fazer tudo, desde a documentação até os comentários de código, tanto em inglês quanto em português.

### Como executar
Clone o repositório e execute-o no Visual Studio ou em qualquer outro editor/IDE de preferência.
É uma aplicação de console simples do dotnet 6.

### Como usar
Uma vez compilado, basta digitar cpusim para mostrar a mensagem de uso (que pode ser diferente para cada commit) e ler as instruções.

## 1ª Lição: Decodificação de Instruções no 8086
Nesta lição, aprenderemos como decodificar as instruções da CPU 8086.
Usaremos as seguintes instruções:
`MOV` registro para registro.

É uma das instruções mais simples de decodificar, tornando-a uma boa introdução sobre como a CPU funciona.

Link para o código: [Lição 1](https://github.com/amelco/cpusim/commit/cb10100c4bbd553a723317b0c8ace3d556677f5d).