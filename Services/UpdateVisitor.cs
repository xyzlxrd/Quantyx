using LibreHardwareMonitor.Hardware;

namespace Quantyx.Services {
    public class UpdateVisitor : IVisitor {
        public void VisitComputer(IComputer computer) {
            computer.Traverse(this); //passa pegano info de todo hardware(CPU,GPU,RAM) PODEPA?
        }

        public void VisitHardware(IHardware hardware) {
            hardware.Update(); //da update wowwww
            foreach(IHardware subHardware in hardware.SubHardware)
                subHardware.Accept(this);
        }

        public void VisitSensor(ISensor sensor) { }

        public void VisitParameter(IParameter parameter) { }//esses 2 são metodos obrigatorios entao nao tem mt explicação!!
    }
}