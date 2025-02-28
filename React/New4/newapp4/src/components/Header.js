import {Link} from 'react-router-dom';
import "./Header.css";
function Header(){
    return(
        <ul>
        <li>Online Food </li>
        <li><Link to="/">Home</Link></li>
        <li><Link to="/aboutus">About Us</Link></li>
        <li><Link to="/contactus">Contact Us</Link></li>
        
        </ul>
    )
}
export default Header;
