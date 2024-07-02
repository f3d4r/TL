string productName = ReadProductName();
int quantity = ReadQuantity();
string userName = ReadUserName();
string address = ReadAddress();
int valid;
DateTime todayDate = new DateTime( 2024, 7, 20 );
OrderConfirmation();
static string ReadUserName()
{
    Console.Write( "Введите свое имя: " );
    string userName = Console.ReadLine();
    while ( string.IsNullOrWhiteSpace( userName ) )
    {
        userName = Console.ReadLine();
    }

    return userName;
}

static string ReadProductName()
{
    Console.Write( "Введите название товара: " );
    string productName = Console.ReadLine();
    while ( string.IsNullOrWhiteSpace( productName ) )
    {
        productName = Console.ReadLine();
    }

    return productName;
}

static int ReadQuantity()
{
    Console.WriteLine( "Введите количество товара: " );
    int quantity;
    while ( !int.TryParse( Console.ReadLine(), out quantity ) || ( quantity == 0 ) )
    {
        Console.WriteLine( "Введите корректное количество товара: " );
    }

    return quantity;
}

static string ReadAddress()
{
    Console.Write( "Введите адрес доставки: " );
    string address = Console.ReadLine();
    while ( string.IsNullOrWhiteSpace( address ) )
    {
        address = Console.ReadLine();
    }

    return address;
}

void OrderConfirmation()
{
    Console.WriteLine( $"Здравствуйте, {userName}, вы заказали {quantity} {productName} на адрес {address}, все верно?" );
    Console.WriteLine( "Введите 1, если верно или 2, если нет " );
    // valid = Console.ReadLine();
    while ( !int.TryParse( Console.ReadLine(), out valid ) || ( valid < 1 ) || ( valid > 2 ) )
    {
        Console.WriteLine( "Введите 1 или 2: " );
    }

    if ( valid == 1 )
    {
        Console.WriteLine( $"{userName}! Ваш заказ {productName} в количестве {quantity} оформлен! Ожидайте доставку по адресу {address} к {todayDate.AddDays( 3 )}" );
    }
    else
    {
        Console.WriteLine( "Заказ не оформлен" );
    }
}