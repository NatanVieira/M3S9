namespace  M3S9.Project
{
    public class CorridaUsuario{
        public bool CorridaEmAndamento { get; set; }

        public bool VerificaCorridaEmAndamento() {
            if(CorridaEmAndamento)
                throw new Exception("Corrida ja esta em andamento.");
            return CorridaEmAndamento;
        }
    }
}