namespace Cine4.Client.Helpers
{
    public struct SelectorMultipleModel
    {
        
        
            public SelectorMultipleModel(string llave, string valor)
            {
                this.Llave = llave;
                this.Valor = valor;
            }
            public string Llave { get; set; }
            public string Valor { get; set; }
        
    }
}
