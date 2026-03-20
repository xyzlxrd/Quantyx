using LibreHardwareMonitor.Hardware;

namespace Quantyx.Services {
    public class HardwareService {
        private Computer computer;

        public HardwareService() {
            computer = new Computer {
                IsCpuEnabled = true,
                IsGpuEnabled = true,
                IsMemoryEnabled = true,
                IsMotherboardEnabled = false,
                IsControllerEnabled = false,
                IsNetworkEnabled = false,
                IsStorageEnabled = true
            };

            computer.Open(); // inicia os sensores
        }

        public void UpdateSensors() {
            computer.Accept(new UpdateVisitor());
        }

        public float? GetCpuTemp() { //funcao que retorna floats(tipo de dado que usa ponto flutuante/ numeros decimais) e o ? é pra permitir q retorne nulo tambem
            foreach(var hardware in computer.Hardware) {
                if(hardware.HardwareType == HardwareType.Cpu) { //percorre CPU
                    foreach(var sensor in hardware.Sensors)
                        if(sensor.SensorType == SensorType.Temperature)
                            return sensor.Value;
                }
            }
            return null;
        }

        public float? GetGpuTemp() {
            foreach(var hardware in computer.Hardware) {
                if(hardware.HardwareType == HardwareType.GpuNvidia || hardware.HardwareType == HardwareType.GpuAmd) { //percorre GPU
                    foreach(var sensor in hardware.Sensors)
                        if(sensor.SensorType == SensorType.Temperature)
                            return sensor.Value;
                }
            }
            return null;
        }

        public float? GetRamUsage() {
            foreach(var hardware in computer.Hardware) {
                if(hardware.HardwareType == HardwareType.Memory) { //percorre RAM
                    foreach(var sensor in hardware.Sensors)
                        if(sensor.SensorType == SensorType.Load)
                            return sensor.Value;
                }
            }
            return null;
        }

        public void Close() {
            computer.Close();
        }
    }
}