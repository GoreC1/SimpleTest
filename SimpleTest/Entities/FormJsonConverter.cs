using SimpleTest.Interfaces;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;


namespace SimpleTest.Entities
{
    // TO-DO
    /*
    public class FormJsonConverter :  Newtonsoft.Json.JsonConverter<Form>
    {
        public override bool CanConvert(Type objectType)
        {
            throw new NotImplementedException();
        }

        /* public override Form Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
                throw new Newtonsoft.Json.JsonException();

            Form form = new Form();

           while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndObject)
                    return form;

                if (reader.TokenType != JsonTokenType.PropertyName)
                    throw new Newtonsoft.Json.JsonException();

                string? propertyName = reader.GetString();
                reader.Read();
                switch (propertyName)
                {
                    case "id":
                        form.id = reader.GetInt32();
                        break;
                    case "name":
                        form.name = reader.GetString();
                        break;
                    case "questions":
                        if(reader.TokenType == JsonTokenType.StartArray)
                        {
                            while (reader.Read())
                            {
                                if (reader.TokenType == JsonTokenType.EndArray)
                                    break;

                            }
                        }
                        break;
                }
            }

            throw new Newtonsoft.Json.JsonException();
        } 

        public override Form ReadJson(JsonReader reader, Type objectType, Form existingValue, bool hasExistingValue, Newtonsoft.Json.JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        /* public override void Write(Utf8JsonWriter writer, Form value, JsonSerializerOptions options)
         {
             writer.WriteStartObject();

             writer.WriteNumber("id", value.id);
             writer.WriteString("name", value.name);
             foreach (var quest in value.questions)
             {
                 writer.WriteBase64StringValue(Newtonsoft.Json.JsonSerializer.Serialize(quest));
             }
         } /
        public override void WriteJson(JsonWriter writer, Form value, Newtonsoft.Json.JsonSerializer serializer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("id");
            writer.WriteValue(value.id);
            writer.WritePropertyName("name");
            writer.WriteValue(value.name);
            writer.WritePropertyName("questions");
            writer.WriteStartArray();
            foreach(var quest in value.questions)
            {
                writer.WriteStartObject();
                
            }
        }
    } */
    
}
