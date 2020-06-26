﻿using System;

namespace UdonSharp.Serialization
{
    public class DefaultSerializer : Serializer
    {
        public DefaultSerializer(TypeSerializationMetadata typeMetadata)
            : base(typeMetadata)
        {
        }

        public override Type GetUdonStorageType()
        {
            throw new NotImplementedException();
        }

        public override bool HandlesTypeSerialization(TypeSerializationMetadata typeMetadata)
        {
            throw new NotImplementedException();
        }

        public override void ReadWeak(ref object targetObject, IValueStorage sourceObject)
        {
            throw new NotImplementedException();
        }

        public override void WriteWeak(IValueStorage targetObject, object sourceObject)
        {
            throw new NotImplementedException();
        }

        protected override Serializer MakeSerializer(TypeSerializationMetadata typeMetadata)
        {
            throw new NotImplementedException();
        }
    }
}

