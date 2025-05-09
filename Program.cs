Console.Clear();

double salario_base, salario_horas, aumento, valor_extra, salario_extras;
int horas_trabalhadas, horas_extras;

Console.Write("Digite seu salário em horas: ");
salario_base = double.Parse(Console.ReadLine());

Console.Write("Digite o total de horas trabalhadas: ");
horas_trabalhadas = int.Parse(Console.ReadLine());

Console.Write("Digite as horas-extras executadas: ");
horas_extras = int.Parse(Console.ReadLine());

salario_horas = salario_base * horas_trabalhadas;

valor_extra= salario_base * 1.40;

salario_extras = valor_extra * horas_extras;

aumento = salario_horas + salario_extras;

Console.Write("O seu salário depois das horas-extras é de: {0:c2}", aumento);