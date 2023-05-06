string resposta = "1234abcd";
string senhadigitada;

Console.Write("Opa opa, Insira sua senha para entrar: ");
senhadigitada = Console.ReadLine()!;

if (senhadigitada != resposta) {
    Console.WriteLine("Senha errada, da próxima vez anote!");
}
if (senhadigitada == resposta) {
    Console.WriteLine("Acesso liberado!");
}