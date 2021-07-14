/********************************/
// 1. struct vs class
/********************************/

// Class - ссылочный тип (Куча, System.Object), наследование, public default
// Struct - значимый тип (Стек, System.Value), БЕЗ наследования, private default

/********************************/
// 2. in, ref, out, as, is
/********************************/

// ref и out - одно и тоже, но в out обзательно присвоить значение переменной

// ref
void func(ref int x) {}
int x;
func(ref x); // error

int x = 5
func(ref x)  // right

//out
void func(out int x) {} // error
void func(out int x) {x = 5}

int x;
// or
int x = 5
func(out x)  // right

// C# 6.0
func(out int x)  // right

// in - становится readonly x = 5 error
// as - преобразует один тип в другой (если ошибка null)
// is - ckeck type between 2 objects (true/ false)

/********************************/
// 3. Сериализация - object to stream of bytes
/********************************/

/********************************/
// 4. Const vs Readonly vs Static
/********************************/

const int X 			// error
const int X = 5  	// неявно static (MyClass.X)
X = 6				// error

readonly int x
readonly int x = 5   // НЕ static (MyClass.x) error 
static readonly x = 5// MyClass.x
x = 6 				// error, но можно в конструторе
x = 6 (static)		// только в static конструкторе

/********************************/
// 5. Boxing vs Unboxing
/********************************/

// Boxing  
int anum = 123;  
Object obj = anum; 

// Unboxing  
Object obj2 = 123;  
int anum2 = (int)obj; 

/********************************/
// 6. Interface vs Abstract Class
/********************************/

// Abstract class: может иметь НЕ абстрактные методы, свойства, конструкторы,
// private default, обязательно слово abstract для методов

// Interface: класс может наследоваться многими интерфейсами
// неявно public и abstract

/********************************/
// 7. String vs StringBuilder
/********************************/

// string is an immutable (неизменяемый) object
// System.Text.Stringbuilder is a mutable (изменяемый) object 
// StringBuilder быстрее string, т.к не создается новый объект

string str = "Hello"
str += "World" 		// create a new string

StringBuilder b = new StringBuilder("Hello")
b.Append("World")	// without creating a new instance of Stringbuilder

 /********************************/
// 8. sealed, partial classes
/********************************/
 
// sealed - запрещает наследование этого класса (sealed class A {}, class B : A // error)
// partial - разделяет класс на части (partial class MyClass {...}, partial class MyClass {...},...)

 /********************************/
// 9. late binding and early binding (связывание)
/********************************/

// Compile Time also known as Early Binding or Overloading
// Run Time is also known as Late Binding or Overriding

// Overloading
int Sum(int x, int y) {return x + y;}
string Sum(string x, string y) {return x + " " + y;}

// Overriding
virtual int Func() {return 1;}
override int Func() {return 2;}

 /********************************/
// 10. (==) and Equals()
/********************************/

int x = 5;
float y = 5.0f;
x == y 		// True 
x.Equals(y) // False (типы должны быть одинаковы)

 /********************************/
// 11. Accessibility Modifiers
/********************************/

// public, private, protected
// internal - доступ из любого места в той же сборке
// protected internal - доступ из текущей сборки и из производных классов
// private protected -  доступ из любого места в текущем классе или в производных классах

// Классы и структуры, объявленные без модификатора, по умолчанию имеют доступ internal.

 /********************************/
// 6. Interface and Abstract Class
/********************************/