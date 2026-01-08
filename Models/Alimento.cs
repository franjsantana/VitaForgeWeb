using System;
using System.Collections.Generic;
using System.Linq;

namespace VitaForgeWeb.Models
{
    public class Alimento
    {
        public string Nombre { get; set; }
        public double PorcionesProteinas { get; set; }
        public double PorcionesCarbohidratos { get; set; }
        public double PorcionesGrasas { get; set; }
        public HashSet<string> ComidasAdecuadas { get; set; }

        public Alimento(string nombre, double porcionesProteinas, double porcionesCarbohidratos, double porcionesGrasas, HashSet<string> comidasAdecuadas)
        {
            Nombre = nombre;
            PorcionesProteinas = porcionesProteinas;
            PorcionesCarbohidratos = porcionesCarbohidratos;
            PorcionesGrasas = porcionesGrasas;
            ComidasAdecuadas = comidasAdecuadas;
        }

        // Lista de alimentos estática
        public static readonly List<Alimento> Alimentos = new List<Alimento>
        {
            // Carbohidratos
            new Alimento("Arroz cocido (100 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Tortilla de maíz (1 pieza/100 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Amaranto (4 cucharadas/25 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Tofu (125 gramos)", 0.5, 0.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Cereales de avena (30 gramos)", 0.0, 0.5, 0.0, new HashSet<string> { "desayuno" }),
            new Alimento("Bolillo (1/2 pieza/100 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "desayuno", "comida", "cena" }),
            new Alimento("Bollo para hamburguesa (1/2 pieza/100 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "cena" }),
            new Alimento("Batata (100 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Cereales (100 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "desayuno" }),
            new Alimento("Magdalenas (30 gramos)", 0.0, 0.5, 0.0, new HashSet<string> { "desayuno" }),
            new Alimento("Croisant (30 gramos)", 0.0, 0.5, 0.0, new HashSet<string> { "desayuno" }),
            new Alimento("Bollo de leche (35 gramos)", 0.0, 0.5, 0.0, new HashSet<string> { "desayuno" }),
            new Alimento("Bizcocho (45 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "desayuno" }),
            new Alimento("Maíz cocido (1/2 pieza/100 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Maíz en grano (1/2 taza/100 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Galletas Marías, (5 piezas/100 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "desayuno" }),
            new Alimento("Medias noches (1/2 pieza/100 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "desayuno", "comida", "cena" }),
            new Alimento("Palomitas naturales (3 tazas/100 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "cena" }),
            new Alimento("Pan árabe (1/2 pieza/100 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "desayuno", "comida", "cena" }),
            new Alimento("Pan integral (1 pieza/100 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "desayuno", "comida", "cena" }),
            new Alimento("Pan blanco (1/2 pieza/100 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "desayuno", "comida", "cena" }),
            new Alimento("Pan de centeno (1/2 pieza/100 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "desayuno", "comida", "cena" }),
            new Alimento("Patata mediana (1 pieza/100 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Verduras (100 gramos)", 0.0, 0.5, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Boniato (100 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Pan de molde (1 rebanada/35 gramos)", 0.0, 0.5, 0.0, new HashSet<string> { "cena" }),
            new Alimento("Quinoa (100 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Sopa de pasta (1/2 taza/100 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Tortilla de nopal (2 piezas/100 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Tostada horneada (2 piezas/100 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "desayuno" }),
            new Alimento("Barra de cereal (1/2 pieza/75 gramos)", 0.0, 1.0, 1.0, new HashSet<string> { "desayuno" }),
            new Alimento("Galletas de avena (2 piezas/75 gramos)", 0.0, 1.0, 1.0, new HashSet<string> { "desayuno" }),
            new Alimento("Granola (3 cucharadas/25 gramos)", 0.0, 1.0, 1.0, new HashSet<string> { "desayuno" }),
            new Alimento("Hot cake/waffle (1 pieza mediana/50 gramos)", 0.0, 1.0, 1.0, new HashSet<string> { "desayuno" }),
            new Alimento("Pan dulce (1/2 pieza/100 gramos)", 0.0, 1.0, 1.0, new HashSet<string> { "desayuno", "comida", "cena" }),
            new Alimento("Tortilla de harina (1/2 pieza/100 gramos)", 0.0, 1.0, 1.0, new HashSet<string> { "comida", "cena" }),
            
            // Frutas
            new Alimento("Arándano (150 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Damasco (4 piezas/100 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Nispero (1/2 pieza/100 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Ciruela pasa (7 piezas/100 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Ciruela roja/amarilla (2 piezas/100 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Fresas (18 piezas/100 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Fruta deshidratada (5 piezas/100 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Granada (1 pieza/100 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Guanábana (1 pieza/100 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Guayaba (3 piezas/100 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Higos (3 piezas/100 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Kiwi (2 piezas/100 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Lima (3 piezas/100 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Mandarina (2 piezas/100 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Mandarina grande (1 pieza/100 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Mango (1 pieza/100 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Manzana mediana (1 pieza/100 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Melón (1 taza/100 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Naranja (3 piezas/100 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Papaya (1 taza/100 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Pasas (2 cucharadas/100 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Pera (1/2 pieza/50 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Piña (1 taza/100 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Plátano (1/2 pieza/75 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Sandía (1 taza/100 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Pomelo (1 pieza/100 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Higos chumbo (3 piezas/100 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Cerezas (100 gramos)", 0.0, 0.5, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Piña (225 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Sandia (350 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Melocoton (1 pieza mediana/100 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Melon (100 gramos)", 0.0, 0.5, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Membrillo (200 gramos)", 0.0, 0.5, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Uva (18 piezas/100 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Zapote (1/2 pieza/100 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "comida", "cena" }),
            
            // Lacteos
            new Alimento("Leche de soja (1 vaso/250ml)", 0.5, 0.0, 0.5, new HashSet<string> { "desayuno" }),
            new Alimento("Leche evaporada entera (1 lata/200 gramos)", 0.5, 0.5, 0.5, new HashSet<string> { "desayuno" }),
            new Alimento("Leche en polvo entera (4 cucharadas/20 gramos)", 0.5, 0.0, 0.5, new HashSet<string> { "desayuno" }),
            new Alimento("Leche en polvo desnatada (4 cucharadas/20gramos)", 0.5, 0.0, 0.0, new HashSet<string> { "desayuno" }),
            new Alimento("Leche entera de vaca (1 vaso/250ml)", 0.5, 0.5, 0.5, new HashSet<string> { "desayuno" }),
            new Alimento("Leche de cabra (1 vaso/250ml)", 0.5, 0.5, 0.5, new HashSet<string> { "desayuno" }),
            new Alimento("Leche de oveja (1 vaso/250ml)", 0.5, 0.5, 1.0, new HashSet<string> { "desayuno" }),

            new Alimento("Yoghurt (1 envase/125 gramos)", 0.5, 0.0, 0.5, new HashSet<string> { "comida", "cena" }),
            new Alimento("Arroz con leche (170 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Flan de huevo (1 envase/125gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Natilla (1 envase/125 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "comida", "cena" }),
            
            // Grasas
            new Alimento("Aceite (2 cucharaditas/10 gramos)", 0.0, 0.0, 1.0, new HashSet<string> { "desayuno" }),
            new Alimento("Jocoque (3/4 taza/100 gramos)", 0.5, 0.0, 0.5, new HashSet<string> { "comida", "cena" }),
            new Alimento("Aderezo (1 cucharada/10 gramos)", 0.0, 0.0, 1.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Aguacate (1/3 pieza/100 gramos)", 0.0, 0.0, 1.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Ajonjolí (1 cucharadita/10 gramos)", 0.0, 0.0, 1.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Mantequilla (1 cucharadita/10 gramos)", 0.0, 0.0, 1.0, new HashSet<string> { "desayuno" }),
            new Alimento("Manteca de cerdo (1 cucharadita/10 gramos)", 0.0, 0.0, 0.5, new HashSet<string> { "desayuno" }),
            new Alimento("Almendras (10 piezas/50 gramos)", 0.0, 0.0, 1.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Avellana (10 piezas/50 gramos)", 0.0, 0.0, 1.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Cacahuetes (14 piezas/50 gramos)", 0.0, 0.0, 1.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Nuez de la India (7 piezas/50 gramos)", 0.0, 0.0, 1.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Nuez castilla (3 piezas/50 gramos)", 0.0, 0.0, 1.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Piñon (1 cucharada/10 gramos)", 0.0, 0.0, 1.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Pistachos (18 piezas/50 gramos)", 0.0, 0.0, 1.0, new HashSet<string> { "comida", "cena" }),
            
            // Legumbres y pastas
            new Alimento("Espaguetis (100 gramos)", 0.0, 1.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Judias (1/2 taza/100 gramos)", 0.5, 1.0, 0.0, new HashSet<string> { "comida" }),
            new Alimento("Garbanzos (1/2 taza/100 gramos)", 0.5, 1.0, 0.0, new HashSet<string> { "comida" }),
            new Alimento("Habas (1/2 taza/100 gramos)", 0.5, 1.0, 0.0, new HashSet<string> { "comida" }),
            new Alimento("Alubias (1/2 taza/100 gramos)", 0.5, 1.0, 0.0, new HashSet<string> { "comida" }),
            new Alimento("Lentejas (1/2 taza/100 gramos)", 0.5, 1.0, 0.0, new HashSet<string> { "comida" }),
            new Alimento("Soja (1/2 taza/100 gramos)", 0.5, 1.0, 0.0, new HashSet<string> { "comida" }),
            new Alimento("Guisantes (100 gramos)", 1.0, 1.0, 0.0, new HashSet<string> { "comida", "cena" }),
            
            // Proteinas
            new Alimento("Atun (1 lata/125 gramos)", 1.0, 0.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Carne de cerdo (100 gramos)", 1.0, 0.0, 1.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Carne de ternera (100 gramos)", 1.0, 0.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Clara de huevo (5 claras/100 gramos)", 1.0, 0.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Huevo entero (2 huevos/125 gramos)", 1.0, 0.0, 1.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Pechuga de pavo (4 rebanadas/100 gramos)", 1.0, 0.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Pechuga de pollo asada (80 gramos)", 1.0, 0.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Pechuga de pavo (100 gramos)", 1.0, 0.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Carne de pato (100 gramos)", 0.5, 0.0, 0.5, new HashSet<string> { "comida", "cena" }),
            new Alimento("Chuleta de cordero (100 gramos)", 0.5, 0.0, 1.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Pescado blanco (100 gramos)", 1.0, 0.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Pescado azul (100 gramos)", 1.0, 0.0, 1.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Queso cottage (9 cucharadas/50 gramos)", 1.0, 0.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Queso fresco de cabra (50 gramos)", 0.5, 0.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Queso mozzarella (30 gramos)", 0.5, 0.0, 1.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Queso Oaxaca (30 gramos)", 0.5, 0.0, 1.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Queso panela (50 gramos)", 0.5, 0.0, 1.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Queso cheddar (50 gramos)", 0.5, 0.0, 0.5, new HashSet<string> { "comida", "cena" }),
            new Alimento("Queso de burgos (75 gramos)", 0.5, 0.0, 0.5, new HashSet<string> { "comida", "cena" }),
            new Alimento("Queso de cabra curado (50 gramos)", 0.5, 0.0, 0.5, new HashSet<string> { "comida", "cena" }),
            new Alimento("Queso gouda (50 gramos)", 0.5, 0.0, 0.5, new HashSet<string> { "comida", "cena" }),
            new Alimento("Queso manchego curado (50 gramos)", 0.5, 0.0, 0.5, new HashSet<string> { "comida", "cena" }),
            new Alimento("Queso parmesano (50 gramos)", 0.5, 0.0, 0.5, new HashSet<string> { "comida", "cena" }),
            new Alimento("Requesón (4 cucharadas)", 0.5, 0.0, 0.0, new HashSet<string> { "comida", "cena" }),
            new Alimento("Salchicha de pavo (1 pieza/50 gramos)", 0.5, 0.0, 0.5, new HashSet<string> { "comida", "cena" }),
            new Alimento("Salmón (100 gramos)", 1.0, 0.0, 0.5, new HashSet<string> { "comida", "cena" }),
            new Alimento("Sardina (100 gramos)", 1.0, 0.0, 0.5, new HashSet<string> { "comida", "cena" }),
            new Alimento("Proteína en polvo (1 toma/25 gramos)", 1.0, 0.0, 0.0, new HashSet<string> { "desayuno", "comida", "cena" })
        };

        // Métodos de lógica del negocio
        /// <summary>
        /// Genera un menú diario completo distribuido en desayuno, comida y cena.
        /// </summary>
        /// <param name="sexo">0 para hombre, 1 para mujer.</param>
        /// <param name="peso">Peso en kilogramos.</param>
        /// <param name="altura">Altura en centímetros.</param>
        /// <param name="edad">Edad en años.</param>
        /// <param name="objetivo">Objetivo nutricional ("perder peso", "mantener", "ganar musculo").</param>
        /// <param name="nivelActividad">Nivel de actividad física ("sedentaria", "leve", "moderada", "intensa").</param>
        /// <returns>Un diccionario con listas de alimentos para cada comida.</returns>
        public static Dictionary<string, List<Alimento>> GenerarMenu(int sexo, double peso, double altura, int edad, string objetivo, string nivelActividad)
        {
            var alimentosPorComida = AgruparAlimentosPorComida(Alimentos);

            // Variables para acumular las porciones (solo declarativas aquí, usamos la lógica interna para cálculos)
            // var proteinasAcumuladas = 0.0;
            // var grasasAcumuladas = 0.0;
            // var carbohidratosAcumulados = 0.0;

            double rmr = CalcularRMR(sexo, peso, altura, edad);
            double energia;

            switch (objetivo.ToLower())
            {
                case "perder peso":
                    // Déficit calórico agresivo (~33%) para pérdida de peso rápida
                    energia = rmr * CalcularFactorActividad(objetivo, nivelActividad) * 0.67;
                    break;
                case "mantener":
                    // Leve déficit (20%) para asegurar mantenimiento sin ganar grasa accidentalmente
                    energia = rmr * CalcularFactorActividad(objetivo, nivelActividad) * 0.8;
                    break;
                case "ganar musculo":
                    // 100% de los requerimientos energéticos para soportar hipertrofia
                    energia = rmr * CalcularFactorActividad(objetivo, nivelActividad) * 1.0;
                    break;
                default:
                    energia = rmr * CalcularFactorActividad(objetivo, nivelActividad);
                    break;
            }

            var factorProteina = CalcularFactorProteina(objetivo, nivelActividad);
            var factorGrasas = CalcularFactorGrasas(objetivo, nivelActividad);

            var proteinas = CalcularProteinas(peso, factorProteina);
            var grasas = CalcularGrasas(peso, factorGrasas);
            var carbohidratos = CalcularCarbohidratos(energia, proteinas, grasas);

            var (porcionesProteinas, porcionesGrasas, porcionesCarbohidratos) = CalcularPorciones(proteinas, grasas, carbohidratos);

            var menuDiario = new Dictionary<string, List<Alimento>>();

            foreach (var kvp in alimentosPorComida)
            {
                string comida = kvp.Key;
                List<Alimento> alimentosComidaList = kvp.Value;

                double limiteProteinas;
                double limiteCarbohidratos;
                double limiteGrasas;

                switch (comida)
                {
                    case "desayuno":
                        // El 30% de la ingesta diaria se asigna al desayuno
                        limiteProteinas = porcionesProteinas * 0.30;
                        limiteCarbohidratos = porcionesCarbohidratos * 0.30;
                        limiteGrasas = porcionesGrasas * 0.30;
                        break;
                    case "comida":
                        // El 40% de la ingesta diaria se asigna a la comida principal
                        limiteProteinas = porcionesProteinas * 0.40;
                        limiteCarbohidratos = porcionesCarbohidratos * 0.40;
                        limiteGrasas = porcionesGrasas * 0.40;
                        break;
                    case "cena":
                        // El 30% restante se asigna a la cena
                        limiteProteinas = porcionesProteinas * 0.30;
                        limiteCarbohidratos = porcionesCarbohidratos * 0.30;
                        limiteGrasas = porcionesGrasas * 0.30;
                        break;
                    default:
                        limiteProteinas = 0.0;
                        limiteCarbohidratos = 0.0;
                        limiteGrasas = 0.0;
                        break;
                }

                var seleccionadosProteinas = SeleccionarAlimentos(alimentosComidaList.Where(a => a.PorcionesProteinas > 0).ToList(), "proteinas", limiteProteinas);
                var seleccionadosCarbohidratos = SeleccionarAlimentos(alimentosComidaList.Where(a => a.PorcionesCarbohidratos > 0).ToList(), "carbohidratos", limiteCarbohidratos);
                var seleccionadosGrasas = SeleccionarAlimentos(alimentosComidaList.Where(a => a.PorcionesGrasas > 0).ToList(), "grasas", limiteGrasas);

                var todosSeleccionados = new List<Alimento>();
                todosSeleccionados.AddRange(seleccionadosProteinas);
                todosSeleccionados.AddRange(seleccionadosCarbohidratos);
                todosSeleccionados.AddRange(seleccionadosGrasas);

                // Distincion y ordenar igual que en Kotlin
                menuDiario[comida] = todosSeleccionados
                    .Distinct()
                    .OrderByDescending(x => x.PorcionesProteinas + x.PorcionesCarbohidratos + x.PorcionesGrasas)
                    .ToList();
            }

            return menuDiario;
        }

        /// <summary>
        /// Algoritmo Greedy (Voraz) con inicialización aleatoria para seleccionar alimentos.
        /// </summary>
        /// <param name="alimentosDisponibles">Lista de candidatos.</param>
        /// <param name="tipoPorcion">Macro a priorizar ("proteinas", "grasas", etc.).</param>
        /// <param name="limitePorciones">Tope a llenar.</param>
        private static List<Alimento> SeleccionarAlimentos(List<Alimento> alimentosDisponibles, string tipoPorcion, double limitePorciones)
        {
            var alimentosSeleccionados = new List<Alimento>();
            var acumulado = 0.0;

            // 1. Aleatoriedad: Mezclamos la lista para garantizar variedad en cada generación
            var random = new Random();
            var mezclados = alimentosDisponibles.OrderBy(x => random.Next()).ToList();

            // 2. Eficiencia: Ordenamos descendente para intentar llenar el cupo con los alimentos más ricos en el nutriente
            var ordenados = mezclados.OrderByDescending(it => // Prioriza los que tienen más cantidad del nutriente que buscamos
            {
                return tipoPorcion switch
                {
                    "proteinas" => it.PorcionesProteinas,
                    "grasas" => it.PorcionesGrasas,
                    "carbohidratos" => it.PorcionesCarbohidratos,
                    _ => 0.0
                };
            }).ToList();

            foreach (var alimento in ordenados)
            {
                var porcion = tipoPorcion switch
                {
                    "proteinas" => alimento.PorcionesProteinas,
                    "grasas" => alimento.PorcionesGrasas,
                    "carbohidratos" => alimento.PorcionesCarbohidratos,
                    _ => 0.0
                };

                if (acumulado + porcion <= limitePorciones)
                {
                    alimentosSeleccionados.Add(alimento);
                    acumulado += porcion;
                }
            }

            return alimentosSeleccionados;
        }

        public static Dictionary<string, List<Alimento>> AgruparAlimentosPorComida(List<Alimento> alimentos)
        {
            var comidas = new List<string> { "desayuno", "comida", "cena" };
            var resultado = new Dictionary<string, List<Alimento>>();

            foreach (var comida in comidas)
            {
                resultado[comida] = alimentos.Where(a => a.ComidasAdecuadas.Contains(comida)).ToList();
            }
            return resultado;
        }

        /// <summary>
        /// Calcula la Tasa Metabólica Basal (RMR) usando la ecuación de Mifflin-St Jeor.
        /// </summary>
        public static double CalcularRMR(int sexo, double peso, double altura, int edad)
        {
            if (sexo == 0) // Hombre
            {
                return (10 * peso) + (6.25 * altura) - (5 * edad) + 5;
            }
            else // Mujer
            {
                return (10 * peso) + (6.25 * altura) - (5 * edad) - 161;
            }
        }

        /// <summary>
        /// Obtiene el multiplicador de actividad física según objetivo y nivel.
        /// </summary>
        public static double CalcularFactorActividad(string objetivo, string nivelActividad)
        {
            var factoresActividad = new Dictionary<string, Dictionary<string, double>>
            {
                { "perder peso", new Dictionary<string, double> {
                    { "sedentaria", 1.00 }, { "leve", 1.20 }, { "moderada", 1.40 }, { "intensa", 1.50 }
                }},
                { "mantener", new Dictionary<string, double> {
                    { "sedentaria", 1.08 }, { "leve", 1.20 }, { "moderada", 1.40 }, { "intensa", 1.60 }
                }},
                { "ganar musculo", new Dictionary<string, double> {
                    { "sedentaria", 1.34 }, { "leve", 1.45 }, { "moderada", 1.53 }, { "intensa", 1.70 }
                }}
            };

            if (factoresActividad.TryGetValue(objetivo.ToLower(), out var niveles))
            {
                if (niveles.TryGetValue(nivelActividad.ToLower(), out var factor))
                {
                    return factor;
                }
            }
            return 1.0;
        }

        /// <summary>
        /// Determina el factor de proteína (g/kg? o factor arbitrario) basado en tablas predefinidas.
        /// </summary>
        public static double CalcularFactorProteina(string objetivo, string nivelActividad)
        {
            var factoresProteina = new Dictionary<string, Dictionary<string, double>>
            {
                { "perder peso", new Dictionary<string, double> {
                    { "sedentaria", 0.75 }, { "leve", 0.85 }, { "moderada", 0.95 }, { "intensa", 1.0 }
                }},
                { "mantener", new Dictionary<string, double> {
                    { "sedentaria", 0.8 }, { "leve", 0.86 }, { "moderada", 1.0 }, { "intensa", 1.05 }
                }},
                { "ganar musculo", new Dictionary<string, double> {
                    { "sedentaria", 1.06 }, { "leve", 1.08 }, { "moderada", 1.1 }, { "intensa", 1.12 }
                }}
            };

            if (factoresProteina.TryGetValue(objetivo.ToLower(), out var niveles))
                if (niveles.TryGetValue(nivelActividad.ToLower(), out var factor))
                    return factor;

            return 1.0;
        }

        /// <summary>
        /// Determina el factor de grasas basado en tablas predefinidas.
        /// </summary>
        public static double CalcularFactorGrasas(string objetivo, string nivelActividad)
        {
            var factoresGrasas = new Dictionary<string, Dictionary<string, double>>
            {
                { "perder peso", new Dictionary<string, double> {
                    { "sedentaria", 0.38 }, { "leve", 0.39 }, { "moderada", 0.43 }, { "intensa", 0.48 }
                }},
                { "mantener", new Dictionary<string, double> {
                    { "sedentaria", 0.38 }, { "leve", 0.39 }, { "moderada", 0.43 }, { "intensa", 0.49 }
                }},
                { "ganar musculo", new Dictionary<string, double> {
                    { "sedentaria", 0.40 }, { "leve", 0.45 }, { "moderada", 0.48 }, { "intensa", 0.5 }
                }}
            };

            if (factoresGrasas.TryGetValue(objetivo.ToLower(), out var niveles))
                if (niveles.TryGetValue(nivelActividad.ToLower(), out var factor))
                    return factor;

            return 1.0;
        }

        /// <summary>
        /// Calcula gramos totales de proteína necesarios (Peso * 2.2 * Factor).
        /// </summary>
        public static int CalcularProteinas(double peso, double factorProteina)
        {
            return (int)Math.Ceiling(peso * 2.2 * factorProteina);
        }

        /// <summary>
        /// Calcula gramos totales de grasa necesarios (Peso * 2.2 * Factor).
        /// </summary>
        public static int CalcularGrasas(double peso, double factorGrasas)
        {
            return (int)Math.Ceiling(peso * 2.2 * factorGrasas);
        }

        /// <summary>
        /// Calcula gramos de carbohidratos restantes para cubrir la energía total.
        /// </summary>
        public static int CalcularCarbohidratos(double energia, double proteinas, double grasas)
        {
            double caloriasProteinas = proteinas * 4;
            double caloriasGrasas = grasas * 9;
            return (int)Math.Ceiling((energia - caloriasProteinas - caloriasGrasas) / 4);
        }

        /// <summary>
        /// Convierte los gramos de macros a "Porciones" estandarizadas del sistema.
        /// (Proteína / 25, Grasa / 15, Carbohidratos / 25).
        /// </summary>
        public static (int, int, int) CalcularPorciones(double proteinas, double grasas, double carbohidratos)
        {
            return (
                (int)Math.Ceiling(proteinas / 25),
                (int)Math.Ceiling(grasas / 15),
                (int)Math.Ceiling(carbohidratos / 25)
            );
        }
    }
}
