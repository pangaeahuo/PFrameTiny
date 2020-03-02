﻿using Unity.Entities;
using Unity.Tiny;
using UnityEngine;

namespace PFrame.Tiny.SimpleUI.Authoring
{
	public class UIElementAuthoring : MonoBehaviour, IConvertGameObjectToEntity
    {
	    //public UnityEngine.Rect Rect;

        public Vector3 Point0 = new Vector3(-1f, -1f, 0f);
        public Vector3 Point1 = new Vector3(-1f, 1f, 0f);
        public Vector3 Point2 = new Vector3(1f, 1f, 0f);
        public Vector3 Point3 = new Vector3(1f, -1f, 0f);

        public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
        {
            var elementComp = new UIElement();
            //elementComp.Rect = new Unity.Tiny.Rect(Rect.xMin, Rect.yMin, Rect.width, Rect.height);
            elementComp.Point0 = Point0;
            elementComp.Point1 = Point1;
            elementComp.Point2 = Point2;
            elementComp.Point3 = Point3;
            dstManager.AddComponentData(entity, elementComp);
        }

        private void OnDrawGizmos()
        {
            //Gizmos.color = UnityEngine.Color.green;
            ////Gizmos.DrawCube(transform.position - new Vector3(Rect.center.x, Rect.center.y), new Vector3(Rect.width, Rect.height));

            //var pos = transform.position;
            //var left = pos.x + Rect.xMin;
            //var right = left + Rect.width;
            //var bottom = pos.y + Rect.yMin;
            //var top = bottom + Rect.height;

            //Gizmos.DrawLine(new Vector3(left, bottom), new Vector3(left, top));
            //Gizmos.DrawLine(new Vector3(left, top), new Vector3(right, top));
            //Gizmos.DrawLine(new Vector3(right, top), new Vector3(right, bottom));
            //Gizmos.DrawLine(new Vector3(right, bottom), new Vector3(left, bottom));

            Gizmos.color = UnityEngine.Color.red;
            var p0 = transform.TransformPoint(Point0);
            var p1 = transform.TransformPoint(Point1);
            var p2 = transform.TransformPoint(Point2);
            var p3 = transform.TransformPoint(Point3);
            Gizmos.DrawLine(p0, p1);
            Gizmos.DrawLine(p1, p2);
            Gizmos.DrawLine(p2, p3);
            Gizmos.DrawLine(p3, p0);
        }
    }
}
