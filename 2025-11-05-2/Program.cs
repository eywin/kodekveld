
int salary = 500_000;
int taxPercent = 30;
int bonus = 20_000;

Console.WriteLine(salary);
salary += bonus;
Console.WriteLine(salary);


// calculate how much you have left after taxes

int taxes = (salary * taxPercent) / 100;

Console.WriteLine(taxes);

int afterTaxes = salary - taxes;
Console.WriteLine(afterTaxes);


// du får en bonus på 20000, legg det til :)

// print