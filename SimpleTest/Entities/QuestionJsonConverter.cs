using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace SimpleTest.Entities
{
    //TO-DO 
    public class QuestionJsonConverter : JsonConverter<Question>
    {
        public override Question ReadJson(JsonReader reader, Type objectType, Question existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, Question value, JsonSerializer serializer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("title");
            writer.WriteValue(value.title); 
            if (value is TextQuestion)
            {
                writer.WritePropertyName("text");
            }
        }
    }
}
