using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid{
    private int width;
    private int height;
    private float cellSize;
    private Vector3 originPosition;
    private int [,] gridArray;
    private TextMesh[,] testArray;
    public Grid(int width, int height, float cellSize, Vector3 originPosition){
        this.width = width;
        this.height = height;
        this.cellSize = cellSize;
        this.originPosition = originPosition;

        gridArray = new int[width, height];
        testArray = new TextMesh[width, height];

        for(int x = 0; x < gridArray.GetLength(0); x++){
            for(int y = 0; y < gridArray.GetLength(1); y++){
                Debug.DrawLine(GetWorldPosition(x,y), GetWorldPosition(x, y + 1), Color.white, 100f);
                Debug.DrawLine(GetWorldPosition(x,y), GetWorldPosition(x + 1, y), Color.white, 100f);
                testArray[x,y] = NewTextObject(null, gridArray[x,y].ToString(), GetWorldPosition(x, y) + new Vector3(cellSize, cellSize) * 0.5f);
            }
        }
        Debug.DrawLine(GetWorldPosition(0, height), GetWorldPosition(width, height), Color.white, 100f);
        Debug.DrawLine(GetWorldPosition(width, 0), GetWorldPosition(width, height), Color.white, 100f);
    }

    private Vector3 GetWorldPosition(int x, int y){
        return new Vector3(x, y) * cellSize + originPosition;
    }

    private void GetXnY(Vector3 worldPosition, out int x, out int y){
        x = Mathf.FloorToInt((worldPosition - originPosition).x / cellSize);
        y = Mathf.FloorToInt((worldPosition - originPosition).y / cellSize);
    }

    public void SetValue(int x, int y, int value){
        if(x >= 0 && y >= 0 && x < width && y < height){
            gridArray[x, y] = value;
            testArray[x, y]. text = gridArray[x, y].ToString();
        }
    }

    public void SetValue(Vector3 worldPosition, int value){
        int x, y;
        GetXnY(worldPosition, out x, out y);
        SetValue(x, y, value);
    }

    public int GetValue(int x, int y){
        if(x >= 0 && y >= 0 && x < width && y < height){
            return gridArray[x, y];
        } 
        else{
            return 0;
        }
    }

    public int GetValue(Vector3 worldPosition){
        int x, y;
        GetXnY(worldPosition, out x, out y);
        return GetValue(x, y);
    }

    public static Vector3 GetMousePosition(Vector3 screenPosition, Camera camera){
        Vector3 position = camera.ScreenToWorldPoint(screenPosition);
        position.z = 0.0f;
        return position;
    }

    public static TextMesh NewTextObject(Transform parent, string text, Vector3 position){
        GameObject gameObject = new GameObject("newObject", typeof(TextMesh));
        Transform transform = gameObject.transform;
        transform.SetParent(parent, false);
        transform.localPosition = position;

        TextMesh textMesh = gameObject.GetComponent<TextMesh>();
        textMesh.text = text;
        textMesh.anchor = TextAnchor.MiddleCenter;
        textMesh.fontSize = 50;
        return textMesh;
    }
}
