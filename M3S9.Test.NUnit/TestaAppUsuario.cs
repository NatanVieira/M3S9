using M3S9.Project;

namespace M3S9.Test.NUnit {

    public class TestaAppUsuario {

        [Test]
        public void VerificaCorridaEmAndamento(){
            CorridaUsuario corrida = new CorridaUsuario();
            corrida.CorridaEmAndamento = true;
            Assert.NotNull(corrida.CorridaEmAndamento);
            Assert.Catch(!corrida.VerificaCorridaEmAndamento());
            Assert.DoesNotThrow(corrida.VerificaCorridaEmAndamento());
        }
    }
}