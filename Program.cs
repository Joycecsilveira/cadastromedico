using cadastro;

Paciente pessoa = new Paciente();
pessoa.nome = "João Neves";
pessoa.idade = 35;
pessoa.altura = 180;
pessoa.peso = 75;

Console.WriteLine("O nome do paciente é: " + pessoa.nome);
Console.WriteLine("A idade do paciente é: " + pessoa.idade);
Console.WriteLine("A altura do paciente é de: " + pessoa.altura);
Console.WriteLine("O peso do paciente é de: " + pessoa.peso + "kg");