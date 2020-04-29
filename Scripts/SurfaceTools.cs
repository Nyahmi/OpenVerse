using Godot;
using System;

namespace OVUtils
{
	Vector3 N = new Vector3( 1, 0, 0);
	Vector3 W = new Vector3( 0, 0, 1);
	Vector3 S = new Vector3(-1, 0, 0);
	Vector3 E = new Vector3( 0, 0, -1);
	Vector3 U = new Vector3( 0, 1, 0);
	Vector3 D = new Vector3( 0,-1, 0);
	
	public class SurfaceTools
	{
		public SurfaceTool getNFace(SurfaceTool st, Vector3 offset)
		{
			//UPPER TRI
			//N E D
			st.add_uv(new Vector2(0,0));
			st.add_vertex(new Vector3( 1 + offset.x,-1 + offset.y,-1 + offset.z));
			
			//N E U
			st.add_uv(new Vector2(0,1));
			st.add_vertex(new Vector3( 1 + offset.x, 1 + offset.y, -1 + offset.z));
			
			//N W U
			st.add_uv(new Vector2(1,1));
			st.add_vertex(new Vector3( 1 + offset.x, 1 + offset.y, 1 + offset.z));
			
			//LOWER TRI
			//N W U
			st.add_uv(new Vector2(1,1));
			st.add_vertex(new Vector3( 1 + offset.x, 1 + offset.y, 1 + offset.z));
			
			//N W D
			st.add_uv(new Vector2(1,0));
			st.add_vertex(new Vector3( 1 + offset.x,-1 + offset.y, 1 + offset.z));
			
			//N E D
			st.add_uv(new Vector2(0,0));
			st.add_vertex(new Vector3( 1 + offset.x,-1 + offset.y,-1 + offset.z));
			
			st.index();
			
			return st;
		}
		
		public SurfaceTool getSFace(SurfaceTool st, Vector3 offset)
		{
			//UPPER TRI
			//S W D
			st.add_uv(new Vector2(0,0));
			st.add_vertex(new Vector3(-1 + offset.x,-1 + offset.y, 1 + offset.z));
			
			//S W U
			st.add_uv(new Vector2(0,1));
			st.add_vertex(new Vector3(-1 + offset.x, 1 + offset.y, 1 + offset.z));
			
			//S E U
			st.add_uv(new Vector2(1,1));
			st.add_vertex(new Vector3(-1 + offset.x, 1 + offset.y,-1 + offset.z));
			
			//LOWER TRI
			//S E U
			st.add_uv(new Vector2(1,1));
			st.add_vertex(new Vector3(-1 + offset.x, 1 + offset.y,-1 + offset.z));
			
			//S E D
			st.add_uv(new Vector2(1,0));
			st.add_vertex(new Vector3(-1 + offset.x,-1 + offset.y,-1 + offset.z));
			
			//S W D
			st.add_uv(new Vector2(0,0));
			st.add_vertex(new Vector3(-1 + offset.x,-1 + offset.y, 1 + offset.z));
			
			st.index();
			
			return st;
		}
		
		public SurfaceTool getWFace(SurfaceTool st, Vector3 offset)
		{
			//Upper Tri
			//N W D
			st.add_uv(new Vector2(0,0));
			st.add_vertex(new Vector3( 1 + offset.x,-1 + offset.y, 1 + offset.z));
			
			//N W U
			st.add_uv(new Vector2(0,1));
			st.add_vertex(new Vector3( 1 + offset.x, 1 + offset.y, 1 + offset.z));
			
			//S W U
			st.add_uv(new Vector2(1,1));
			st.add_vertex(new Vector3(-1 + offset.x, 1 + offset.y, 1 + offset.z));
			
			//LOWER TRI
			//S W U
			st.add_uv(new Vector2(1,1));
			st.add_vertex(new Vector3(-1 + offset.x, 1 + offset.y, 1 + offset.z));
			
			//S W D
			st.add_uv(new Vector2(1,0));
			st.add_vertex(new Vector3(-1 + offset.x,-1 + offset.y, 1 + offset.z));
			
			//N W D
			st.add_uv(new Vector2(0,0));
			st.add_vertex(new Vector3( 1 + offset.x,-1 + offset.y, 1 + offset.z));
			
			st.index();
			
			return st;
		}
	}
	
}
