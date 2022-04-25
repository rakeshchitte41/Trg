import { conditionallyCreateMapObjectLiteral } from '@angular/compiler/src/render3/view/util';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent  {
  data:any=[
  {Electronics: "Mobile", Fashions: "WomenWear", Accessories:"Rings", Footwear: "Sandal"},
  {Electronics: "Grinder", Fashions: "MenWear", Accessories:"Pendants", Footwear: "Heels"},
  {Electronics: "WashingMachine", Fashions: "TopWear", Accessories:"Bracelet", Footwear: "Flats"},
  {Electronics: "Refridgerator", Fashions: "BottomWear", Accessories:"Chains", Footwear: "Slipper"},
  {Electronics: "Alexa", Fashions: "WinterWear", Accessories:"NeckLace", Footwear: "Shoes"},
  {Electronics: "EarPhones", Fashions: "KidsWear", Accessories:"Lockets", Footwear: "Wedges"},
  {Electronics: "Mobile", Fashions: "WomenWear", Accessories:"Rings", Footwear: "Sandal"},
  {Electronics: "Grinder", Fashions: "MenWear", Accessories:"Pendants", Footwear: "Heels"},
  {Electronics: "WashingMachine", Fashions: "TopWear", Accessories:"Bracelet", Footwear: "Flats"},
  {Electronics: "Refridgerator", Fashions: "BottomWear", Accessories:"Chains", Footwear: "Slipper"},
  {Electronics: "Alexa", Fashions: "WinterWear", Accessories:"NeckLace", Footwear: "Shoes"},
  {Electronics: "EarPhones", Fashions: "KidsWear", Accessories:"Lockets", Footwear: "Wedges"}
  
  ];
  
/*table(){
    if(this.Table == true)
    {
      return "";
    }
    
  else{
    return "none";
  }
}*/
  Electronics:boolean=true;
elec(){
    if(this.Electronics == false)
    {
      return "";
    }
    
  else{
    return "none";
  }
}
electronics()
{
  this.Electronics=!this.Electronics
}
Fashions:boolean=true;
fash(){
    if(this.Fashions == false)
    {
      return "";
    }
    
  else{
    return "none";
  }
}
fashions()
{
  this.Fashions=!this.Fashions
}
Accessories:boolean=true;
acces(){
    if(this.Accessories == false)
    {
      return "";
    }
    
  else{
    return "none";
  }
}
accessories()
{
  this.Accessories=!this.Accessories
}

Footwear:boolean=true;
foot(){
    if(this.Footwear == false)
    {
      return "";
    }
    
  else{
    return "none";
  }
}
footwear()
{
  this.Footwear=!this.Footwear
}

}
