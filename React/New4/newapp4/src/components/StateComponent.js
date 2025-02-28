import r from 'react' 

class StateComponent extends r.Component 

{ 

constructor(props) 

{ 

super(props); 

this.state = { 

    counter : 0 

}; 

this.handleClick = this.handleClick.bind(this); // we are binding the even handler with the current class 

} 

handleClick() 

{ 

   

this.setState({counter :this.state.counter+1}); // To update 

    console.log("Counter Value"+ this.state.counter); 

} 

render() 

{ 

    let {counter} =this.state; 

  return( 

    <div> 

     

        <button onClick={this.handleClick}> Press to continue</button> 

        <div> Counter variable has incremented {counter}</div> 

     

    </div> 

 

    ) 

  } 

 

 

} 

export default StateComponent; 