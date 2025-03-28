import useState from "react";
const Third = () => {
    const[data , Setdata] = useState({
        firstname :"",
        lastname:"",
        fullname:""
    }
    )

    const show =() =>{

    }

    return(
        <div>
            <label>FirstName: </label>
            <input type = "text" name= "firstName" 
            value ={data.firstname}/>
            
            <label>LastName</label>
            <input type= "text" name ="lastName"
            value ={data.lastname} />
            
            <label>FullName</label>
            <input type= "text" name ="fullName"
            value ={data.fullname} />

            <input type = "button" value ="Show" onClick={show}/>

        </div>
    )
}