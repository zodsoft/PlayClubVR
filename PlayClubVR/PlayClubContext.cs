﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using VRGIN.Core;
using VRGIN.Visuals;

namespace PlayClubVR
{
    public class PlayClubContext : IVRManagerContext
    {

        private DefaultMaterialPalette _Materials;
        private VRSettings _Settings;

        public PlayClubContext()
        {
            _Materials = new DefaultMaterialPalette();
            _Settings = VRSettings.Load<PlayClubSettings>("vr_settings.xml");

            _Materials.StandardShader = Shader.Find("Marmoset/Specular IBL");
        }

        public string GuiLayer
        {
            get
            {
                return "Ignore Raycast";
            }
        }

        public string InvisibleLayer
        {
            get
            {
                return "ScreenShot";
            }
        }

        public IMaterialPalette Materials
        {
            get
            {
                return _Materials;
            }
        }

        public Color PrimaryColor
        {
            get
            {
                return Color.cyan;
            }
        }
        
        public VRSettings Settings
        {
            get
            {
                return _Settings;
            }
        }

        public int UILayerMask
        {
            get
            {
                return LayerMask.GetMask(UILayer);
            }
        }

        public string UILayer
        {
            get
            {
                return "UI";
            }
        }

        public bool SimulateCursor
        {
            get
            {
                return false;
            }
        }

        public bool GUIAlternativeSortingMode
        {
            get
            {
                return true;
            }
        }
    }
}
