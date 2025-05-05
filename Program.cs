
int nVariableUNO = 10;
int nVariableDOS = 5;

Console.WriteLine("OPERADORES UNARIOS INCREMENTO (++) \n");
Console.WriteLine($" El valor de la variable UNO es: {nVariableUNO++}. Al colocarle en código C# el operador ++ DESPUÉS del nombre de la variable (nVariableUNO++) " +
           $"hace que el valor de la variable incremente DESPUÉS de usarla. \n Ahora al mostrar en pantala el valor de la variable UNO es: {nVariableUNO} . \n ");

Console.WriteLine($" El valor de la variable DOS es: {nVariableDOS}. Al colocarle en código C# el operador ++ ANTES del nombre de la variable (++nVariableDOS) " +
           $"hace que el valor de la variable incremente ANTES de usarla. \n Ahora al mostrar en pantala el valor de la variable DOS es: {++nVariableDOS} . \n\n");

nVariableUNO = 10;
nVariableDOS = 5;

Console.WriteLine("OPERADORES UNARIOS DECREMENTO (--) \n");
Console.WriteLine($" El valor de la variable UNO es: {nVariableUNO--}. Al colocarle en código C# el operador -- DESPUÉS del nombre de la variable (nVariableUNO--) " +
           $"hace que el valor de la variable tenga un decremento DESPUÉS de usarla. \n Ahora al mostrar en pantala el valor de la variable UNO es: {nVariableUNO} . \n");

Console.WriteLine($" El valor de la variable DOS es : {nVariableDOS--}. Al colocarle en código C# el operador -- ANTES del nombre de la variable (--nVariableDOS) " +
           $"hace que el valor de la variable decremente ANTES de usarla. \n Ahora al mostrar en pantala el valor de la variable DOS es: {nVariableDOS} . \n");