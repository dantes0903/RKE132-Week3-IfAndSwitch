

Console.WriteLine("Enter a number:");
    int userNUm = Convert.ToInt32(Console.ReadLine());

//kas kasutaja arv on paaris või paaritu

int result = userNUm % 2;

if(result != 0) //!= - ei ole
{
    Console.WriteLine("User number is odd.");
} else
{
    Console.WriteLine("User number is even.");
}

