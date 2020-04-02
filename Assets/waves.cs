using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waves : MonoBehaviour
{
    public int dimensionX=10;
    public int dimensionZ=10;
    protected Mesh Mesh;
    protected MeshFilter MeshFilter;
    public float UVScale;
    public int height=3;
    protected float clockbound=4f;

    // Start is called before the first frame update
    void Start()
    {
        
        Mesh=new Mesh();
        Mesh.name=gameObject.name;
        Mesh.vertices=GenerateVerts();
        Mesh.triangles=GenerateTries();
        Mesh.uv=GenerateUVs();
        Mesh.RecalculateBounds();
        Mesh.RecalculateNormals();

        MeshFilter=gameObject.AddComponent<MeshFilter>();
        MeshFilter.mesh=Mesh;
    

        
    }
    private Vector3[]GenerateVerts()
    {
       var verts=new Vector3[((dimensionX+1)*(dimensionZ+1))] ;
       for (int x=0;x<=dimensionX;x++){
         for (int z=0;z<=dimensionZ;z++){
             verts [index(x,z) ]=new Vector3(x,0,z);
            
         }
       }
       return verts;
    }
    private int index(int x, int z){
           return x*(dimensionZ+1)+z;
    }
    private int []GenerateTries(){
        var tries=new int [Mesh.vertices.Length*6];
          for (int x=0;x<dimensionX;x++){
            for (int z=0;z<dimensionZ;z++){
                tries[index(x,z)*6+0]=index(x,z);
                tries[index(x,z)*6+1]=index(x+1,z+1);
                tries[index(x,z)*6+2]=index(x+1,z);
                tries[index(x,z)*6+3]=index(x,z);
                tries[index(x,z)*6+4]=index(x,z+1);
                tries[index(x,z)*6+5]=index(x+1,z+1);

            }
            }
        return tries;
    }

    

    // Update is called once per frame
    void Update()
    {
        var verts=Mesh.vertices;
        for(int z=0;z<=dimensionZ;z++){
             for(int x=0;x<=dimensionX;x++){
                 var y=0f;
                 
            y+=height*Mathf.Cos(z*2f*Mathf.PI/dimensionZ+Time.time);
                
                verts[index(x,z)]=new Vector3 (x,y,z);
             }
        }
        Mesh.vertices=verts;
        Mesh.RecalculateNormals();
    }
    private Vector2[] GenerateUVs()
    {
        var uvs= new Vector2[Mesh.vertices.Length];
          for (int x=0;x<dimensionX;x++){
            for (int z=0;z<dimensionZ;z++){
                var vec = new Vector2((x/UVScale)%2,(z/UVScale)%2);
                uvs[index(x,z)]= new Vector2(vec.x<=1?vec.x:2-vec.x,vec.y<=1?vec.y:2-vec.y);
            }
          }
          return uvs;
    }
}
