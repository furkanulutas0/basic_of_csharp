namespace Namespace {
    
    public static class Module {
        
        public static object isimYazdirma(object name) {
            Console.WriteLine("Hello, {name}");
        }
        
        static Module() {
            isimYazdirma("Furkan");
        }
    }
}