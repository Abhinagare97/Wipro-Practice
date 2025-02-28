// import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import './App.css';
import AboutUs from './components/AboutUs';
import ContactUs from './components/ContactUs';
import Main from './components/Main'


// function App() {
// return(
// <Router>

// <Routes>
// <Route path ='/about' element = {<AboutUs></AboutUs>}></Route>
// <Route path ='/contact' element = {<ContactUs></ContactUs>}></Route>

// </Routes>
// </Router>
// );

// }

// export default App;
import React from "react";
import Header from "./components/Header";
import Main from "./components/Main";
import Footer from "./components/Footer";
import "./App.css";

function App() {
  return (
    
    <div className="App">
      <Header />
      <Main />
      <Footer />
    </div>
  );
}

export default App;