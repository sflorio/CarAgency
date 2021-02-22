import React, { useState } from 'react';
import { MenuItemsVehiculos } from './MenuItemsVehiculos';
import './Dropdown.css';
import { Link } from 'react-router-dom';

function Dropdown() {
  const [click, setClick] = useState(false);

  const handleClick = () => setClick(!click);

  return (

      <ul
        className={'dropdown-menu'}
      >
        {MenuItemsVehiculos.map((item, index) => {
          return (
            <li key={index}>
              <Link
                className={item.cName}
                to={item.path}
                onClick={() => setClick(false)}
              >
                {item.title}
              </Link>
            </li>
          );
        })}
      </ul>
  );
}

export default Dropdown;
