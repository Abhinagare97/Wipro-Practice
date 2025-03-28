import { useState } from "react";
//const { useState } = require("react")

const First =() => {

    const [name , setName]= useState("");
    const pranathi = () => {
        setName("Hi I am Pranathi...")
    }
    return (
        <div>
            Student name is {name}
            <button onClick={pranathi}>Pranathi</button>

        </div>
    )
}

export default First;