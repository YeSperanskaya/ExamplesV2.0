﻿// Вид 1
void Method1()
{
    Console.WriteLine("Автор Сперанская Евгения");
}
//Method1();
//Method1();



// Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg:"Text", count: 4);
//Method21(count: 4, msg: "новый текст");

