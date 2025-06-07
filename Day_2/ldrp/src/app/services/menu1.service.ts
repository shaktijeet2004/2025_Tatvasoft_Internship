import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class Menu1Service {

  constructor() { }

  onSubmit(name: string){
    console.log("IN SERVICE");
    // Here you can add logic to handle the name submission, like sending it to a server or processing it further.
    console.log(name);
  } 
}
