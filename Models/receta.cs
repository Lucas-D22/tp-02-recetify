public class receta{
    public string name {get; set;}
    public DateTime fechaDeNacimiento {get; set;}
    public bool TipoComida {get; set;} = true;
// true = caliente false = frio
    public int presupuestoPesos {get; set;}
    public int cocinaPara {get; set;}


    public int calcularEdad()
    {
        DateTime hoy = DateTime.Today;
        int edad = hoy.Year - fechaDeNacimiento.Year;
        if(hoy.Month < fechaDeNacimiento.Month){
            edad --;
        }
        else if(hoy.Day < fechaDeNacimiento.Day){
            edad--;
        }
        return edad;
    }

public string DeterminarPlato()
{
  
  if(TipoComida && presupuestoPesos < 3000)
  {
    return "fideos con manteca";
  }
  else if(TipoComida && presupuestoPesos >= 3000 && presupuestoPesos <= 7000){
    return "arroz con verduras salteadas";
  }
  else if(TipoComida && presupuestoPesos > 7000){
    return "pollo al horno con guarnicion";
  }
  else if(!TipoComida && presupuestoPesos < 3000){
    return "ensalada simple";
  }
  else if(!TipoComida && presupuestoPesos >= 3000 && presupuestoPesos <= 7000){
    return "ensalada completa con proteina";
  }
  else if (!TipoComida && presupuestoPesos > 7000){
    return "tabla de fiambres y quesos";
  }
  else{
    return null;
  }
}
/*
CalcularTiempo(): retorna los minutos estimados. El tiempo se calcula en base a CantidadPersonas usando una fórmula numérica: a más personas, 
más tiempo. Los platos fríos deben tardar menos que los calientes.
*/
public int calcularTiempo(){

if (cocinaPara == 1 && TipoComida){
    return 20;
}
else if(cocinaPara == 2 || cocinaPara == 3 && TipoComida){
    return 20;
}
else if(cocinaPara >= 4 && cocinaPara <=7 && TipoComida){
    return 40;
}
else if (cocinaPara < 8 && TipoComida){
    return 80;
}
else if(cocinaPara >= 1 && cocinaPara <=3 && !TipoComida){
    return 10;
}
else if(cocinaPara >= 4 && cocinaPara <=7 && !TipoComida){
    return 20;
}
else if(cocinaPara < 8 && !TipoComida){
    return 40;
}
else{
    return 0;
}

}


public string determinarDificultad(){
    if(presupuestoPesos < 3000 && cocinaPara <= 1 && cocinaPara >= 3){
        return "principiante";
    }
    else if(presupuestoPesos > 3000 && cocinaPara <= 1 && cocinaPara >= 7){
        return "intermedio";
    }
    else if(presupuestoPesos > 7000 && cocinaPara >= 8){
        return "avanzado";
    }
    else{
        return null;
    }
}



}