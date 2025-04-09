namespace Khalevin_s_cool_sapr
{
    [Serializable]
    public class Beam
    {
        public int Id { get; set; }                // Уникальный идентификатор стержня
        public double Length { get; set; }        // Длина стержня
        public double CrossSectionArea { get; set; } // Площадь сечения
        public double DistributedForce { get; set; } // Распределённая сила
        public double Elasticity { get; set; }    // Модуль упругости
        public double AllowableStress { get; set; } // Допустимое напряжение
    }
}
