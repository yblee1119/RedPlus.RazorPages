using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RedPlus.Models
{
    public class Portfolio
    {
        /// <summary>
        /// 모델 클래스: Model, ViewModel, dto, Object, Entity, ... 등의 클래스명에 접미사를 붙일 수 있으나 그냥 Portfolio라고 하였음
        /// </summary>
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        
        [JsonPropertyName("img")]
        public string Image { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize<Portfolio>(this);
        }
    }
}
