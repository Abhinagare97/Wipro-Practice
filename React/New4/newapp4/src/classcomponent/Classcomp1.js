import React from 'react';
class Classcomp1 extends React.Component{
    render(){
       return(
        <div>
        <h1>This is from Class component</h1>
       <h1> Hello {this.props.username}</h1>
       </div>
       )
    }
}
export default Classcomp1;