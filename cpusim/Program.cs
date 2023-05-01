using cpusim;

if (args.Length < 1)
{
    Console.WriteLine("Uso:\n\tcpusim [arquivo_de_entrada] [debug]");
    return;
}

var input = File.ReadAllBytes(args[0]);
bool isDebugging = args.Length > 1 && args[1].ToLower() == "debug";

if (input == null)
{
    Console.WriteLine("Erro lendo arquivo de entrada.");
    return;
}

Debug.Info(isDebugging, $"Tamanho do arquivo de entrada: {input.Length} bytes");
Console.WriteLine("bits 16");

// Lê até o fim do arquivo de entrada, de 2 em 2 bytes
// Read file until the end, 2 bytes at a time
for (int i = 0; i < input.Length; i += 2)
{
    var byte1 = input[i];
    var byte2 = input[i + 1];

    //var opcode = (byte1 >> 2) & 0b100010;

    Opcode? opcode = GetOpcode(byte1);
    if (opcode is null)
        throw new Exception($"Instrução inválida. Byte: {Convert.ToString(byte1, 2)}");


    string instrucao = "";

    if (opcode == Opcode.mov)
    {
        instrucao = "mov ";

        bool d = ((byte1 & 0b00000010) == 0b00000010);
        bool w = ((byte1 & 0b00000001) == 0b00000001);
        var mod = (byte2 >> 6) & 0b11;
        var reg = (byte2 >> 3) & 0b111;
        var rm = byte2 & 0b111;


        int source, destination;
        if (d)
        {
            destination = reg;
            source = rm;
        }
        else
        {
            destination = rm;
            source = reg;
        }

        if (mod == 0b11) // register to register
        {
            string strDest = GetRegisterName(destination, w);
            string strSrc = GetRegisterName(source, w);
            instrucao += $"{strDest}, {strSrc}";
        }

        Debug.Info(isDebugging, $"{Convert.ToString(byte1, 2)} {Convert.ToString(byte2, 2)} => {instrucao}");
        Debug.Info(isDebugging, $"d: {d}\nw: {w}\nmod: {Convert.ToString(mod, 2)}\nreg: {Convert.ToString(reg, 2)}\nrm: {Convert.ToString(rm, 2)}");
    }

    Console.WriteLine(instrucao);
}

Opcode? GetOpcode(byte byte1)
{
    if (((byte1 >> 2) & (int)Opcode.mov) == (int)Opcode.mov)
        return Opcode.mov;

    return null;
}

string GetRegisterName(int value, bool wide)
{
    string? result = null;

    // De acordo com tabela 4-9 do manual 8086 pg. 162 (ou 4-20)
    // According to table 4-9 from 8086 manual pg. 162 (ou 4-20)
    // 8086 manual: https://edge.edx.org/c4x/BITSPilani/EEE231/asset/8086_family_Users_Manual_1_.pdf
    if (value == 0b000) result = !wide ? "al" : "ax";
    if (value == 0b001) result = !wide ? "cl" : "cx";
    if (value == 0b010) result = !wide ? "dl" : "dx";
    if (value == 0b011) result = !wide ? "bl" : "bx";

    if (value == 0b100) result = !wide ? "ah" : "sp";
    if (value == 0b101) result = !wide ? "ch" : "bp";
    if (value == 0b110) result = !wide ? "dh" : "si";
    if (value == 0b111) result = !wide ? "bh" : "di";

    if (result is null)
        throw new Exception("Operação inválida.");

    return result;
}
