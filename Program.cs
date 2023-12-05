for (int m = 1000; m <= 1500;m++)
{
    int n = amistoso(m);
    if (n != m && amistoso(n) == m){
        Console.WriteLine($"{m}, {n}");

    }
}

static int amistoso (int numero){
    int sum=  0;

    for (int i = 1; i < numero; i++)
    { 
        if (numero % i == 0){
            sum += i;
        }
    }
    return sum;
}