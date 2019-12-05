using Domain.Common;
using Domain.Enums;

namespace Domain.Entities
{
    public class Flat : AuditableEntity
    {
        public int Id { get; set; }
        /// <summary>
        /// Address: district, street, house number etc.
        /// </summary>
        public Address Address { get; set; }
        /// <summary>
        /// Количество комнат
        /// </summary>
        public RoomCount Rooms { get; set; }
        /// <summary>
        /// Активно или нет 
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        /// Цена 
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Описание квартиры
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Фотография объявления
        /// </summary>
        public string Image { get; set; }
    }
}
