namespace AutorizadorSuccess.Libreria
{
    public class Resultado
    {
        public bool Success { get; set; } = false;
        public string Messages { get; set; } = string.Empty;
        public int IdleTime { get; set; } = 0;
    }
}
