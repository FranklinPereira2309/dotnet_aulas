
//var tupla1 = (id:10, name: "Helder", born: new DateTime(1987, 9, 24));
//Console.WriteLine($"Tupla1: {tupla1.id}, {tupla1.name}, {tupla1.born}");

//list.Add(tupla1);


//List<(int id, string name, DateTime born)> list = new();


//list.Add((11, "Franklin", new DateTime(1977, 09,23)));

//list.ForEach(x => Console.WriteLine($"Tuple 1: {x.id}, {x.name}, {x.born.ToShortDateString()}") );
#region Questão 1
    /*DateTime hoje = DateTime.Now;

        Console.WriteLine("Dia do nascimento (dd): ");

        int dia = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Dia do mês (mm): ");

        int mes = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ano de nascimento (yyyy): ");

        int ano = Convert.ToInt32(Console.ReadLine());

        string nome = Console.ReadLine();
        DateTime nascimento = DateTime.Parse(Console.ReadLine());

        DateTime nascimento = new DateTime(ano, mes, dia);

        int idade = hoje.Year - nascimento.Year;

        Console.WriteLine(idade);*/

        
#endregion

#region 
/*string[] people = {"Franklin", "Gabriel", "Adriana"};

char letter = 'G';

Console.WriteLine($"Pessoas começadas com '{letter}': {string.Join(", ", people.Where(x => x.StartsWith(letter)).Select(x => x.ToUpper()))} ");*/
#endregion

/*#region 
List<int> list = new() {1,2,3,4,5};
var squaredList = list.Select(x => x * x);
Console.WriteLine($"Original List: {string.Join(", ", list )}");
Console.WriteLine($"Squareed List: {string.Join(", ", squaredList)}");

#endregion*/

/*#region 

try
{
    int result = Divide(10,0);
    Console.WriteLine($"Result: {result}");
}
catch (DivideByZeroException ex)
{
    
    Console.WriteLine("Error: Cannot divide by zero");
    Console.WriteLine(ex.Message);
}
catch (Exception ex) 
{
    Console.WriteLine("An error occurred");
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Finally block executed");
}

int Divide(int a, int b) {
    if(b == 0) {
        throw new DivideByZeroException("Cannot divide by zero");
    }
    return a / b;
}

#endregion*/

    using System.Globalization;
    CultureInfo culturaBrasileira = new CultureInfo("pt-BR");
#region 

    DateTime now = DateTime.Now;
    Console.WriteLine("Data e Hora Atuais: " + now.ToString("dd/MM/yyyy"));

    DateTime dataEspecifica = new DateTime(2023, 11, 21);
    Console.WriteLine("Data Específica: " + dataEspecifica);

    String formatoEspecifico = now.ToString("dd/MM/yyyy HH:mm:ss");
    Console.WriteLine(formatoEspecifico);

    DateTime daquiDoisDias = now.AddDays(2);
    String daquiString = daquiDoisDias.ToString("dd/MM/yyyy");
    DateTime umaHoraAtras = now.AddHours(-1);
    String umaHoraString = umaHoraAtras.ToString("dd/MM/yyyy HH:mm:ss");

    Console.WriteLine(daquiString);
    Console.WriteLine(umaHoraString);



#endregion