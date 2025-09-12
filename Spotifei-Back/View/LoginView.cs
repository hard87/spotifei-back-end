static class LoginView
{
    public static void Exibir()
    {
        string login = "";
        string senha = "";

        System.Console.WriteLine("Bem-vind@ ao Spotifei!\n");
        System.Console.WriteLine("Por favor, insira suas credenciais:\n");
        System.Console.WriteLine("Login:");
        login = Console.ReadLine();
        System.Console.WriteLine("Senha:");
        senha = Console.ReadLine();

        if (login == "" && senha =="")//(new LoginController().Autenticar(login, senha))
        {
            System.Console.WriteLine("Usuario autenticado com sucesso! Pressione Enter para continuar.");
            //Console.ReadKey();
            //InterfaceInicialView.Exibir();
        }
        else
        {
            System.Console.WriteLine("Login e/ou Senha incorretos. Pressione Enter para tentar novamente.");
            Console.ReadKey();
            Console.Clear();
            Exibir();
        }
    }
}