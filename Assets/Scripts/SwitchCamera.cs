using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RandomCamera : MonoBehaviour
{
    public Camera cam_prox;
    public Camera cam_wasp;
    public Camera cam_cancri;
    public Camera cam_pega;
    public Camera cam_kep;
    public Camera cam_gj1;
    public Camera cam_HD1;
    public Camera cam_HD2;
    public Camera cam_k2;
    public Camera cam_kep452;

    public async void SwitchCamera()
    {   
        List<Camera> cameras = new List<Camera>() {cam_prox, cam_wasp, cam_cancri, cam_pega, cam_kep, cam_gj1, cam_HD1, cam_HD2, cam_k2, cam_kep452};
        
            // Generate a random index
           int randomIndex = Random.Range(0, cameras.Count);
           Camera cur = cameras[randomIndex];
            cameras.RemoveAt(randomIndex);
            foreach (Camera x in cameras) {
                x.enabled = false;
            }
            cameras[randomIndex].enabled = true;

    }

}