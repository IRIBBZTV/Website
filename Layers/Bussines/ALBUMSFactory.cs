using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Bazaar.BusinessLayer.DataLayer;

namespace Bazaar.BusinessLayer
{
    public class ALBUMSFactory
    {

        #region data Members

        ALBUMSSql _dataObject = null;

        #endregion

        #region Constructor

        public ALBUMSFactory()
        {
            _dataObject = new ALBUMSSql();
        }

        #endregion


        #region Public Methods

        /// <summary>
        /// Insert new ALBUMS
        /// </summary>
        /// <param name="businessObject">ALBUMS object</param>
        /// <returns>true for successfully saved</returns>
        public int Insert(ALBUMS businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Insert(businessObject);

        }

        /// <summary>
        /// Update existing ALBUMS
        /// </summary>
        /// <param name="businessObject">ALBUMS object</param>
        /// <returns>true for successfully saved</returns>
        public bool Update(ALBUMS businessObject)
        {
            if (!businessObject.IsValid)
            {
                throw new InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString());
            }


            return _dataObject.Update(businessObject);
        }

        /// <summary>
        /// get ALBUMS by primary key.
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>Student</returns>
        public ALBUMS GetByPrimaryKey(ALBUMSKeys keys)
        {
            return _dataObject.SelectByPrimaryKey(keys); 
        }

        /// <summary>
        /// get list of all ALBUMSs
        /// </summary>
        /// <returns>list</returns>
        public List<ALBUMS> GetAll()
        {
            return _dataObject.SelectAll(); 
        }

        /// <summary>
        /// get list of ALBUMS by field
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>list</returns>
        //public List<ALBUMS> GetAllBy(ALBUMS.ALBUMSFields fieldName, object value)
        //{
        //    return _dataObject.SelectByField(fieldName.ToString(), value);  
        //}

        /// <summary>
        /// delete by primary key
        /// </summary>
        /// <param name="keys">primary key</param>
        /// <returns>true for succesfully deleted</returns>
        public bool Delete(ALBUMSKeys keys)
        {
            return _dataObject.Delete(keys); 
        }

        /// <summary>
        /// delete ALBUMS by field.
        /// </summary>
        /// <param name="fieldName">field name</param>
        /// <param name="value">value</param>
        /// <returns>true for successfully deleted</returns>
        public bool Delete(ALBUMS.ALBUMSFields fieldName, object value)
        {
            return _dataObject.DeleteByField(fieldName.ToString(), value); 
        }

        #endregion

    }
}
