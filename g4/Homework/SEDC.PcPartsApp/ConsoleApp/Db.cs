using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public static class Db
    {
        public static List<Part> Parts = new List<Part>() {
            new Part(1, 380, 1, 0.10, "AMD Ryzen 5 2600", PartType.Cpu, "AMD", true),
            new Part(2, 660, 1, 0.10, "AMD Ryzen 7 2700X", PartType.Cpu, "AMD", true),
            new Part(3, 720, 1, 0, "Intel Core i7-8700K", PartType.Cpu, "Intel", true),
            new Part(4, 420, 1, 0, "Intel Core i5-9400F", PartType.Cpu, "Intel", true),
            new Part(5, 20, 1, 0, "Corsair H60", PartType.CpuCooler, "Corsair", false),
            new Part(6, 30, 1, 0, "Noctua NH-D15", PartType.CpuCooler, "Noctua", false),
            new Part(7, 40, 1, 0.15, "NZXT Kraken X72", PartType.CpuCooler, "NZXT", true),
            new Part(8, 35, 1, 0, "CRYORIG H7", PartType.CpuCooler, "CRYORIG", false),
            new Part(9, 600, 1, 0, "MSI RX 580 ARMOR", PartType.Gpu, "MSI", false),
            new Part(10, 720, 1, 0, "Asus ROG-STRIX", PartType.Gpu, "Asus", true),
            new Part(45, 1500, 2, 0, "Asus ROG-STRIX(dual chanel)", PartType.Gpu, "Asus", true),
            new Part(11, 370, 1, 0.20, "Zotac ZT", PartType.Gpu, "Zotac", false),
            new Part(12, 440, 1, 0, "Gigabyte GV", PartType.Gpu, "Gigabyte", true),
            new Part(13, 55, 1, 0, "ARCTIC Accelero", PartType.GpuCooler, "ARCTIC", false),
            new Part(14, 80, 1, 0, "Kraken G12", PartType.GpuCooler, "NZXT", true),
            new Part(15, 40, 1, 0, "Deepcool TESSERACT", PartType.Case, "Deepcool", false),
            new Part(16, 90, 1, 0, "Cooler Master MasterBox", PartType.Case, "Cooler Master", false),
            new Part(18, 75, 1, 0, "Corsair 200R", PartType.Case, "Corsair", false),
            new Part(19, 110, 1, 0.10, "EVGA SuperNOVA", PartType.PowerSuply, "EVGA", false),
            new Part(20, 140, 1, 0, "Corsair CX450", PartType.PowerSuply, "Corsair", false),
            new Part(21, 160, 1, 0, "SeaSonic FOCUS", PartType.PowerSuply, "SeaSonic", true),
            new Part(22, 200, 1, 0, "MSI B450 TOMAHAWK", PartType.MotherBoard, "MSI", true),
            new Part(23, 230, 1, 0.25, "ASRock B450 Pro4", PartType.MotherBoard, "ASRock", true),
            new Part(24, 340, 1, 0, "Asus Prime X470-Pro", PartType.MotherBoard, "Asus", true),
            new Part(25, 10, 1, 0, "Standard Power Cable", PartType.PowerCable, "MSI", false),
            new Part(26, 60, 1, 0, "Samsung MZ", PartType.SSD, "Samsung", true),
            new Part(27, 70, 1, 0.40, "Seagate MZ", PartType.SSD, "Seagate", false),
            new Part(28, 65, 1, 0, "Western Digital MZ", PartType.SSD, "Western Digital", true),
            new Part(29, 65, 1, 0, "Seagate ST", PartType.HDD, "Seagate", false),
            new Part(30, 80, 1, 0, "Samsung ST", PartType.HDD, "Samsung", true),
            new Part(31, 60, 1, 0, "Corsair Vengeance", PartType.RAM, "AMD", true),
            new Part(32, 70, 1, 0, "Kingston FURY", PartType.RAM, "Kingston", true),
            new Part(33, 140, 2, 0, "Kingston FURY(dual chanel)", PartType.RAM, "Kingston", true),
            new Part(34, 330, 1, 0.10, "HP OMEN X", PartType.Monitor, "HP", true),
            new Part(35, 200, 1, 0, "MSI Optix", PartType.Monitor, "MSI", true),
            new Part(37, 380, 2, 0, "MSI Optix(double)", PartType.Monitor, "MSI", true),
            new Part(39, 8, 1, 0, "Logitech M510", PartType.Mouse, "Logitech", false),
            new Part(42, 20, 1, 0, "VicTsing MM057", PartType.Mouse, "VicTsing", false),
            new Part(43, 10, 1, 0, "Logitech G213", PartType.Keyboard, "Logitech", false),
            new Part(44, 30, 1, 0.29, "Redragon K502", PartType.Keyboard, "Redragon", false)
        };
        public static List<Module> Modules = new List<Module>()
        {
            new Module(50, 700, 0.10, ModuleType.Graphics, new List<Part>(){
                Parts[8],
                Parts[13]
            }),
            new Module(51, 820, 0, ModuleType.Graphics, new List<Part>(){
                Parts[9],
                Parts[14]
            }),
            new Module(52, 100, 0.20, ModuleType.Casing, new List<Part>(){
                Parts[15],
                Parts[20]
            }),
            new Module(53, 140, 0.15, ModuleType.Casing, new List<Part>(){
                Parts[16],
                Parts[19]
            }),
            new Module(54, 750, 0.10, ModuleType.Processing, new List<Part>(){
                Parts[1],
                Parts[5]
            }),
            new Module(55, 840, 0, ModuleType.Processing, new List<Part>(){
                Parts[2],
                Parts[4]
            }),
            new Module(56, 340, 280, ModuleType.Memory, new List<Part>(){
                Parts[25],
                Parts[28],
                Parts[30]
            }),
            new Module(57, 250, 320, ModuleType.Memory, new List<Part>(){
                Parts[27],
                Parts[32]
            }),
            new Module(58, 260, 0, ModuleType.MainBoard, new List<Part>(){
                Parts[22],
                Parts[24],
                Parts[24],
                Parts[24]
            }),
            new Module(59, 350, 0, ModuleType.MainBoard, new List<Part>(){
                Parts[23],
                Parts[24],
                Parts[24]
            }),
            new Module(60, 300, 0, ModuleType.Other, new List<Part>(){
                Parts[34],
                Parts[36],
                Parts[38]
            }),
            new Module(61, 460, 0, ModuleType.Other, new List<Part>(){
                Parts[37],
                Parts[39]
            }),

        };
        public static List<Configuration> Configurations = new List<Configuration>()
        {
            new Configuration(80, 1000, 0.10, "Office Deluxe", ConfigurationType.Office, new List<Module>() {
                Modules[1],
                Modules[3],
                Modules[5],
                Modules[7],
                Modules[9],
                Modules[11]
            }),
            new Configuration(80, 800, 0.10, "Office Basic", ConfigurationType.Office, new List<Module>() {
                Modules[2],
                Modules[4],
                Modules[6],
                Modules[8],
                Modules[10],
                Modules[12]
            }),
            new Configuration(80, 1300, 0.10, "Personal 2000", ConfigurationType.Standard, new List<Module>() {
                Modules[1],
                Modules[4],
                Modules[5],
                Modules[8],
                Modules[10],
                Modules[11]
            }),
            new Configuration(80, 1800, 0.10, "Gamer Extreme", ConfigurationType.Gaming, new List<Module>() {
                Modules[2],
                Modules[3],
                Modules[5],
                Modules[7],
                Modules[10],
                Modules[12]
            }),


        };

    }
}
