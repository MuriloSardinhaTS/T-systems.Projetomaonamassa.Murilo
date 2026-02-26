# 🟦 Verificação de Idade – Aplicação Console (C#)

Este repositório contém uma aplicação simples em **C# (Console Application)** desenvolvida como solução para um desafio proposto. O objetivo é solicitar uma idade ao usuário e exibir uma mensagem com cores diferentes dependendo do resultado da validação.

---

## 🎯 Desafio

> Desenvolver uma aplicação do tipo **Console** com as seguintes especificações:
>
> - Solicitar uma **idade** ao usuário.
> - Se a idade for **menor que 18 anos**, exibir em **vermelho**:
>   - **"Sem permissão"**
> - Se a idade for **maior ou igual a 18 anos**, exibir em **verde**:
>   - **"Permissão concedida"**

---

## 🧠 Lógica da Aplicação

1. O programa solicita a idade ao usuário.
2. Converte a entrada para número inteiro.
3. Verifica se a idade é menor que 18.
4. Exibe a mensagem apropriada em **vermelho** ou **verde**.
5. Restaura a cor padrão do console ao final.

---

## 🖥️ Tecnologias Utilizadas

- C#
- .NET Console Application
- Entrada e saída de dados pelo console
- Manipulação de cores com `Console.ForegroundColor`

---

## 📌 Exemplo de Funcionamento

### 🔴 Idade menor que 18 anos

Digite sua idade: 15
Sem permissão


### 🟢 Idade maior ou igual a 18 anos

Digite sua idade: 20
Permissão concedida


---

## 📄 Código-fonte (trecho principal)

```csharp
Console.Write("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine());

if (idade < 18)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Sem permissão");
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Permissão concedida");
}

Console.ResetColor();
Console.ReadKey();
🚀 Como Executar

Clone o repositório:

git clone https://github.com/SEU-USUARIO/NOME-DO-REPO.git

Acesse a pasta:

cd NOME-DO-REPO

Execute o projeto:

dotnet run
📝 Considerações Finais

Este projeto demonstra conceitos iniciais de:

Estruturas condicionais

Manipulação de cores no console

Entrada de dados

Lógica básica de programação

Serve como um ótimo exercício para quem está começando com C#.
