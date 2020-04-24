using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace CustomMath
{
    public struct PlaneA2
    {
        #region Variables
        Vec3 _a;
        Vec3 _b;
        Vec3 _c;
        #endregion

        //
        // Resumen:
        //     Creates a plane.
        //
        // Parámetros:
        //   inNormal:
        //
        //   inPoint:
        public PlaneA2(Vec3 inNormal, Vec3 inPoint)
        {
            _a = Vec3.Zero;
            _b = inNormal;
            _c = inPoint;
        }
        //
        // Resumen:
        //     Creates a plane.
        //
        // Parámetros:
        //   a:
        //
        //   b:
        //
        //   c:
        public PlaneA2(Vec3 a, Vec3 b, Vec3 c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        //
        // Resumen:
        //     Normal vector of the plane.
        public Vec3 normal { get; set; }
        //
        // Resumen:
        //     Distance from the origin to the plane.
        public float distance { get; set; }
        //
        // Resumen:
        //     Returns a copy of the plane that faces in the opposite direction.
        public PlaneA2 flipped { get; }

        //
        // Resumen:
        //     Returns a copy of the given plane that is moved in space by the given translation.
        //
        // Parámetros:
        //   plane:
        //     The plane to move in space.
        //
        //   translation:
        //     The offset in space to move the plane with.
        //
        // Devuelve:
        //     The translated plane.
        public static PlaneA2 Translate(PlaneA2 plane, Vec3 translation)
        {

        }
        //
        // Resumen:
        //     For a given point returns the closest point on the plane.
        //
        // Parámetros:
        //   point:
        //     The point to project onto the plane.
        //
        // Devuelve:
        //     A point on the plane that is closest to point.
        public Vec3 ClosestPointOnPlane(Vec3 point)
        {

        }
        //
        // Resumen:
        //     Makes the plane face in the opposite direction.
        public void Flip()
        {

        }
        //
        // Resumen:
        //     Returns a signed distance from plane to point.
        //
        // Parámetros:
        //   point:
        public float GetDistanceToPoint(Vec3 point)
        {

        }
        //
        // Resumen:
        //     Is a point on the positive side of the plane?
        //
        // Parámetros:
        //   point:
        public bool GetSide(Vec3 point)
        {

        }
        public bool SameSide(Vec3 inPt0, Vec3 inPt1)
        {

        }
        //
        // Resumen:
        //     Sets a plane using three points that lie within it. The points go around clockwise
        //     as you look down on the top surface of the plane.
        //
        // Parámetros:
        //   a:
        //     First point in clockwise order.
        //
        //   b:
        //     Second point in clockwise order.
        //
        //   c:
        //     Third point in clockwise order.
        public void Set3Points(Vec3 a, Vec3 b, Vec3 c)
        {

        }
        //
        // Resumen:
        //     Sets a plane using a point that lies within it along with a normal to orient
        //     it.
        //
        // Parámetros:
        //   inNormal:
        //     The plane's normal vector.
        //
        //   inPoint:
        //     A point that lies on the plane.
        public void SetNormalAndPosition(Vec3 inNormal, Vec3 inPoint)
        {

        }
        public override string ToString()
        {

        }
        public string ToString(string format)
        {

        }
        //
        // Resumen:
        //     Moves the plane in space by the translation vector.
        //
        // Parámetros:
        //   translation:
        //     The offset in space to move the plane with.
        public void Translate(Vec3 translation)
        {

        }
    }
}
