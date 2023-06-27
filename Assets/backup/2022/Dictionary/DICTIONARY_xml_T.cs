//Bo52_1810202015161842.DICTIONARY<T>
namespace dictionary2022
{
    using System.Xml.Serialization;
    using UnityEngine;
    using class2022;
    using utility2022;
    using mb2022;
    /// <summary>
    /// ulong
    /// Список ulong (Координаты объектов)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DICTIONARY_xml<T> : DICTIONARY_f<T>, IXmlSerializable
    {
        public object obj;
        #region IXmlSerializable 
        public System.Xml.Schema.XmlSchema GetSchema()=>null;
        public System.Action Serializer_load;
        public System.Action Serializer_save;
        public System.Action el_new;
        public T ЗагрузитьЗначениеСерилизации(ref XmlSerializer valueSerializer, System.Xml.XmlReader reader, object obj)
        {

            //if (typeof(T) == typeof(Bo52_16102020101639302.World_ch_block))
            //{
            //object b = new Bo52_16102020101639302.World_ch_block((Bo52_16102020101639302.World_ch_block.STRUCT)valueSerializer.Deserialize(reader), obj);
            //return (T)b;
            //}
            //if (typeof(T) == typeof(Bo52_31122020120752813.BLOCK))
            //{
            //object b = new Bo52_31122020120752813.BLOCK((Bo52_31122020120752813.BLOCK.STRUCT)valueSerializer.Deserialize(reader), obj);
            //return (T)b;
            //}
            Serializer_load?.Invoke();
            return (T)valueSerializer.Deserialize(reader);
        }
        public void СохранитьЗначениеСерилизации(ref XmlSerializer valueSerializer, System.Xml.XmlWriter writer, ulong key)
        {
            T value = this[key];
            //if (typeof(T) == typeof(Bo52_16102020101639302.World_ch_block))
            //{
                //valueSerializer.Serialize(writer, new Bo52_16102020101639302.World_ch_block.STRUCT(value as Bo52_16102020101639302.World_ch_block));
            //} 
            //else if (typeof(T) == typeof(Bo52_31122020120752813.BLOCK))
            //{
                //valueSerializer.Serialize(writer, new Bo52_31122020120752813.BLOCK.STRUCT(value as Bo52_31122020120752813.BLOCK));
            //}
            //else
            valueSerializer.Serialize(writer, value);
        }
        public XmlSerializer ОпределитьСерилизацию()=>new XmlSerializer(typeof(T));
        //Загрузить из XML
        public void Загрузить(string filename, object OBJ=null)
        {
            obj = OBJ;
            Clear();
            if (System.IO.File.Exists(filename + ".xml") == false)
                return;

            System.Xml.XmlReader reader = System.Xml.XmlReader.Create(filename + ".xml");

            ReadXml(reader);
        }
        public void ReadXml(System.Xml.XmlReader reader)
        {
            XmlSerializer keySerializer = new XmlSerializer(typeof(ulong));
            XmlSerializer valueSerializer = ОпределитьСерилизацию();
            bool wasEmpty = reader.IsEmptyElement;
            reader.Read();
            if (wasEmpty)
                return;

            reader.ReadStartElement("users");

            while (reader.NodeType != System.Xml.XmlNodeType.EndElement)
            {
                if (reader.NodeType == System.Xml.XmlNodeType.None)
                    return;
                reader.ReadStartElement("item");

                reader.ReadStartElement("key");
                ulong key = (ulong)keySerializer.Deserialize(reader);
                reader.ReadEndElement();

                reader.ReadStartElement("value");
                T value = ЗагрузитьЗначениеСерилизации(ref valueSerializer, reader,obj);
                reader.ReadEndElement();

                this.Add(key, value);

                reader.ReadEndElement();

                reader.MoveToContent();
            }
            reader.ReadEndElement();
        }
        //сохранить из XML
        public void Сохранить(string filename)
        {
            System.IO.FileStream stream = System.IO.File.Open(filename + ".xml", System.IO.FileMode.OpenOrCreate);
            //System.Xml.XmlReaderSettings settings = new System.Xml.XmlReaderSettings();
            //settings.DtdProcessing = System.Xml.DtdProcessing.Parse;

            System.Xml.XmlWriterSettings settings = new System.Xml.XmlWriterSettings();
            settings.OmitXmlDeclaration = false;
            settings.ConformanceLevel = System.Xml.ConformanceLevel.Document;
            settings.CloseOutput = true;
            settings.Indent = true;

            System.Xml.XmlWriter writer = System.Xml.XmlWriter.Create(stream, settings);
            WriteXml(writer);
        }

        public void WriteXml(System.Xml.XmlWriter writer)
        {
            XmlSerializer keySerializer = new XmlSerializer(typeof(ulong));
            XmlSerializer valueSerializer = ОпределитьСерилизацию();          

            writer.WriteStartDocument();
            writer.WriteStartElement("users");
            foreach (ulong key in this.Keys)
            {
                writer.WriteStartElement("item");

                writer.WriteStartElement("key");
                keySerializer.Serialize(writer, key);
                writer.WriteEndElement();

                writer.WriteStartElement("value");
                СохранитьЗначениеСерилизации(ref valueSerializer, writer,key);

                writer.WriteEndElement();

                writer.WriteEndElement();
            }
            writer.WriteEndDocument();
            writer.Close();
        }
        #endregion
        /// <summary>
        /// координата в пространстве
        /// </summary>
        public T НайтиНаСцене(Vector3 v)
        {
            //if  (typeof(T)== typeof(Bo52_17102020101208823.MONO_17102020101208823))
            //{
                //var go=GameObject.Find("CHUNK-" + v.x + "-" + v.y + "-" + v.z);
                //if (go == null) 
                    //return default;
                //return (T)(object)go.GetComponent<Bo52_17102020101208823.MONO_17102020101208823>();
//}
            return default;
        }

        public T ЭЛЕМЕНТ(Vector3 v)=>ЭЛЕМЕНТ(stVector_number_h8.GET_ID(v), v);
        public T ЭЛЕМЕНТ(ulong id, Vector3 v)
        {
            var в = Найти(id);
            if (в == null)
            {
                в = НайтиНаСцене(v);
                if (в != null) 
                    return в;
                //ЧАНК
                //if (typeof(T)== typeof(Bo52_17102020101208823.MONO_17102020101208823))
                //{
                    //var mono = Bo52_05112020143719936.FUN.новый(v);
                    //mono.gameObject.transform.position = v;
                    //return (T)(object)mono;
                //}
                в = stExample.GetObject<T>();
                //if (в is Bo52_1510202013173769.CLASS) 
                //{
                //    var B = в as Bo52_1510202013173769.CLASS;
                //    B.Update(id,new Vector3Int((int)v.x, (int)v.y, (int)v.z));
                //}
                //if (в is Bo52_16102020101639302.World_ch_block)
                //{
                    //var B = в as Bo52_16102020101639302.CLASS;
                    //B.КодРассчитан = 1;
                //}
                Add(id,в);
            }
            return в;
        }
    }
}
