/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace libsbml {

 using System;
 using System.Runtime.InteropServices;

/** 
 * @sbmlpackage{core}
 *
@htmlinclude pkg-marker-core.html An attribute on an XML node.
 *
 * @htmlinclude not-sbml-warning.html
 */

public class XMLAttributes : IDisposable {
	private HandleRef swigCPtr;
	protected bool swigCMemOwn;
	
	internal XMLAttributes(IntPtr cPtr, bool cMemoryOwn)
	{
		swigCMemOwn = cMemoryOwn;
		swigCPtr    = new HandleRef(this, cPtr);
	}
	
	internal static HandleRef getCPtr(XMLAttributes obj)
	{
		return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
	}
	
	internal static HandleRef getCPtrAndDisown (XMLAttributes obj)
	{
		HandleRef ptr = new HandleRef(null, IntPtr.Zero);
		
		if (obj != null)
		{
			ptr             = obj.swigCPtr;
			obj.swigCMemOwn = false;
		}
		
		return ptr;
	}

  ~XMLAttributes() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libsbmlPINVOKE.delete_XMLAttributes(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public static bool operator==(XMLAttributes lhs, XMLAttributes rhs)
  {
    if((Object)lhs == (Object)rhs)
    {
      return true;
    }

    if( ((Object)lhs == null) || ((Object)rhs == null) )
    {
      return false;
    }

    return (getCPtr(lhs).Handle.ToString() == getCPtr(rhs).Handle.ToString());
  }

  public static bool operator!=(XMLAttributes lhs, XMLAttributes rhs)
  {
    return !(lhs == rhs);
  }

  public override bool Equals(Object sb)
  {
    if ( ! (sb is XMLAttributes) )
    {
      return false;
    }

    return this == (XMLAttributes)sb;
  }

  public override int GetHashCode()
  {
    return swigCPtr.Handle.ToInt32();
  }

  
/**
   * Creates a new empty XMLAttributes set.
   */ public
 XMLAttributes() : this(libsbmlPINVOKE.new_XMLAttributes__SWIG_0(), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Copy constructor; creates a copy of this XMLAttributes set.
   *
   * @p orig the XMLAttributes object to copy.
   *
   * @throws XMLConstructorException
   * Thrown if the argument @p orig is @c null.
   */ public
 XMLAttributes(XMLAttributes orig) : this(libsbmlPINVOKE.new_XMLAttributes__SWIG_1(XMLAttributes.getCPtr(orig)), true) {
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
  }

  
/**
   * Creates and returns a deep copy of this XMLAttributes object.
   *
   * @return the (deep) copy of this XMLAttributes object.
   */ public
 XMLAttributes clone() {
    IntPtr cPtr = libsbmlPINVOKE.XMLAttributes_clone(swigCPtr);
    XMLAttributes ret = (cPtr == IntPtr.Zero) ? null : new XMLAttributes(cPtr, true);
    return ret;
  }

  
/**
   * Adds an attribute (a name/value pair) to this XMLAttributes object,
   * optionally with a prefix and URI defining a namespace.
   *
   * @param name a string, the local name of the attribute.
   * @param value a string, the value of the attribute.
   * @param namespaceURI a string, the namespace URI of the attribute.
   * @param prefix a string, the prefix of the namespace
   *
   * @return an integer code indicating the success or failure of the
   * function.  The possible values returned by this
   * function are:
   * @li @link libsbmlcs#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS@endlink
   *
   * @note if local name with the same namespace URI already exists in this 
   * attribute set, its value and prefix will be replaced.
   *
   * @ifnot hasDefaultArgs @htmlinclude warn-default-args-in-docs.html @endif
   */ public
 int add(string name, string value, string namespaceURI, string prefix) {
    int ret = libsbmlPINVOKE.XMLAttributes_add__SWIG_0(swigCPtr, name, value, namespaceURI, prefix);
    return ret;
  }

  
/**
   * Adds an attribute (a name/value pair) to this XMLAttributes object,
   * optionally with a prefix and URI defining a namespace.
   *
   * @param name a string, the local name of the attribute.
   * @param value a string, the value of the attribute.
   * @param namespaceURI a string, the namespace URI of the attribute.
   * @param prefix a string, the prefix of the namespace
   *
   * @return an integer code indicating the success or failure of the
   * function.  The possible values returned by this
   * function are:
   * @li @link libsbmlcs#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS@endlink
   *
   * @note if local name with the same namespace URI already exists in this 
   * attribute set, its value and prefix will be replaced.
   *
   * @ifnot hasDefaultArgs @htmlinclude warn-default-args-in-docs.html @endif
   */ public
 int add(string name, string value, string namespaceURI) {
    int ret = libsbmlPINVOKE.XMLAttributes_add__SWIG_1(swigCPtr, name, value, namespaceURI);
    return ret;
  }

  
/**
   * Adds an attribute (a name/value pair) to this XMLAttributes object,
   * optionally with a prefix and URI defining a namespace.
   *
   * @param name a string, the local name of the attribute.
   * @param value a string, the value of the attribute.
   * @param namespaceURI a string, the namespace URI of the attribute.
   * @param prefix a string, the prefix of the namespace
   *
   * @return an integer code indicating the success or failure of the
   * function.  The possible values returned by this
   * function are:
   * @li @link libsbmlcs#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS@endlink
   *
   * @note if local name with the same namespace URI already exists in this 
   * attribute set, its value and prefix will be replaced.
   *
   * @ifnot hasDefaultArgs @htmlinclude warn-default-args-in-docs.html @endif
   */ public
 int add(string name, string value) {
    int ret = libsbmlPINVOKE.XMLAttributes_add__SWIG_2(swigCPtr, name, value);
    return ret;
  }

  
/**
   * Adds an attribute with the given XMLTriple/value pair to this XMLAttributes set.
   *
   * @note if local name with the same namespace URI already exists in this attribute set, 
   * its value and prefix will be replaced.
   *
   * @param triple an XMLTriple, the XML triple of the attribute.
   * @param value a string, the value of the attribute.
   *
   * @return integer value indicating success/failure of the
   * function. The possible values
   * returned by this function are:
   * @li @link libsbmlcs#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS@endlink
   */ public
 int add(XMLTriple triple, string value) {
    int ret = libsbmlPINVOKE.XMLAttributes_add__SWIG_3(swigCPtr, XMLTriple.getCPtr(triple), value);
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Removes an attribute with the given index from this XMLAttributes set.  
   *
   * @param n an integer the index of the resource to be deleted
   * @return integer value indicating success/failure of the
   * function. The possible values
   * returned by this function are:
   * @li @link libsbmlcs#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS@endlink
   * @li @link libsbmlcs#LIBSBML_INDEX_EXCEEDS_SIZE LIBSBML_INDEX_EXCEEDS_SIZE@endlink
   */ public
 int removeResource(int n) {
    int ret = libsbmlPINVOKE.XMLAttributes_removeResource(swigCPtr, n);
    return ret;
  }

  
/**
   * Removes an attribute with the given index from this XMLAttributes set.  
   * (This function is an alias of XMLAttributes::removeResource(@if java int@endif) ).
   *
   * @param n an integer the index of the resource to be deleted
   *
   * @return integer value indicating success/failure of the
   * function. The possible values
   * returned by this function are:
   * @li @link libsbmlcs#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS@endlink
   * @li @link libsbmlcs#LIBSBML_INDEX_EXCEEDS_SIZE LIBSBML_INDEX_EXCEEDS_SIZE@endlink
   */ public
 int remove(int n) {
    int ret = libsbmlPINVOKE.XMLAttributes_remove__SWIG_0(swigCPtr, n);
    return ret;
  }

  
/**
   * Removes an attribute with the given local name and namespace URI from 
   * this XMLAttributes set.  
   *
   * @param name   a string, the local name of the attribute.
   * @param uri    a string, the namespace URI of the attribute.
   *
   * @return integer value indicating success/failure of the
   * function. The possible values
   * returned by this function are:
   * @li @link libsbmlcs#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS@endlink
   * @li @link libsbmlcs#LIBSBML_INDEX_EXCEEDS_SIZE LIBSBML_INDEX_EXCEEDS_SIZE@endlink
   */ public
 int remove(string name, string uri) {
    int ret = libsbmlPINVOKE.XMLAttributes_remove__SWIG_1(swigCPtr, name, uri);
    return ret;
  }

  
/**
   * Removes an attribute with the given local name and namespace URI from 
   * this XMLAttributes set.  
   *
   * @param name   a string, the local name of the attribute.
   * @param uri    a string, the namespace URI of the attribute.
   *
   * @return integer value indicating success/failure of the
   * function. The possible values
   * returned by this function are:
   * @li @link libsbmlcs#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS@endlink
   * @li @link libsbmlcs#LIBSBML_INDEX_EXCEEDS_SIZE LIBSBML_INDEX_EXCEEDS_SIZE@endlink
   */ public
 int remove(string name) {
    int ret = libsbmlPINVOKE.XMLAttributes_remove__SWIG_2(swigCPtr, name);
    return ret;
  }

  
/**
   * Removes an attribute with the given XMLTriple from this XMLAttributes set.  
   *
   * @param triple an XMLTriple, the XML triple of the attribute.
   *
   * @return integer value indicating success/failure of the
   * function. The possible values
   * returned by this function are:
   * @li @link libsbmlcs#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS@endlink
   * @li @link libsbmlcs#LIBSBML_INDEX_EXCEEDS_SIZE LIBSBML_INDEX_EXCEEDS_SIZE@endlink
   */ public
 int remove(XMLTriple triple) {
    int ret = libsbmlPINVOKE.XMLAttributes_remove__SWIG_3(swigCPtr, XMLTriple.getCPtr(triple));
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Clears (deletes) all attributes in this XMLAttributes object.
   *
   * @return integer value indicating success/failure of the
   * function. The possible values
   * returned by this function are:
   * @li @link libsbmlcs#LIBSBML_OPERATION_SUCCESS LIBSBML_OPERATION_SUCCESS@endlink
   */ public
 int clear() {
    int ret = libsbmlPINVOKE.XMLAttributes_clear(swigCPtr);
    return ret;
  }

  
/**
   * Return the index of an attribute with the given name.
   *
   * @note A namespace bound to the name is not checked by this function.
   * Thus, if there are multiple attributes with the given local name and
   * different namespaces, the smallest index among those attributes will
   * be returned.  XMLAttributes::getIndex(string name, string uri) or
   * XMLAttributes::getIndex(XMLTriple triple) should be used to get an index of an
   * attribute with the given local name and namespace.
   *
   * @param name a string, the local name of the attribute for which the 
   * index is required.
   *
   * @return the index of an attribute with the given local name, or -1 if not present.
   */ public
 int getIndex(string name) {
    int ret = libsbmlPINVOKE.XMLAttributes_getIndex__SWIG_0(swigCPtr, name);
    return ret;
  }

  
/**
   * Return the index of an attribute with the given local name and namespace URI.
   *
   * @param name a string, the local name of the attribute.
   * @param uri  a string, the namespace URI of the attribute.
   *
   * @return the index of an attribute with the given local name and namespace URI, 
   * or -1 if not present.
   */ public
 int getIndex(string name, string uri) {
    int ret = libsbmlPINVOKE.XMLAttributes_getIndex__SWIG_1(swigCPtr, name, uri);
    return ret;
  }

  
/**
   * Return the index of an attribute with the given XMLTriple.
   *
   * @param triple an XMLTriple, the XML triple of the attribute for which 
   *        the index is required.
   *
   * @return the index of an attribute with the given XMLTriple, or -1 if not present.
   */ public
 int getIndex(XMLTriple triple) {
    int ret = libsbmlPINVOKE.XMLAttributes_getIndex__SWIG_2(swigCPtr, XMLTriple.getCPtr(triple));
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Return the number of attributes in the set.
   *
   * @return the number of attributes in this XMLAttributes set.
   */ public
 int getLength() {
    int ret = libsbmlPINVOKE.XMLAttributes_getLength(swigCPtr);
    return ret;
  }

  
/**
   * Return the number of attributes in the set.
   *
   * @return the number of attributes in this XMLAttributes set.
   *
   * This function is an alias for getLength introduced for consistency
   * with other XML classes.
   */ public
 int getNumAttributes() {
    int ret = libsbmlPINVOKE.XMLAttributes_getNumAttributes(swigCPtr);
    return ret;
  }

  
/**
   * Return the local name of an attribute in this XMLAttributes set (by position).
   *
   * @param index an integer, the position of the attribute whose local name is 
   * required.
   *
   * @return the local name of an attribute in this list (by position).  
   *
   * @note If index is out of range, an empty string will be returned.  Use
   * XMLAttributes::hasAttribute(int index) to test for the attribute
   * existence.
   */ public
 string getName(int index) {
    string ret = libsbmlPINVOKE.XMLAttributes_getName(swigCPtr, index);
    return ret;
  }

  
/**
   * Return the prefix of an attribute in this XMLAttributes set (by position).
   *
   * @param index an integer, the position of the attribute whose prefix is 
   * required.
   *
   * @return the namespace prefix of an attribute in this list (by
   * position).  
   *
   * @note If index is out of range, an empty string will be returned. Use
   * XMLAttributes::hasAttribute(int index) to test for the attribute
   * existence.
   */ public
 string getPrefix(int index) {
    string ret = libsbmlPINVOKE.XMLAttributes_getPrefix(swigCPtr, index);
    return ret;
  }

  
/**
   * Return the prefixed name of an attribute in this XMLAttributes set (by position).
   *
   * @param index an integer, the position of the attribute whose prefixed 
   * name is required.
   *
   * @return the prefixed name of an attribute in this list (by
   * position).  
   *
   * @note If index is out of range, an empty string will be returned.  Use
   * XMLAttributes::hasAttribute(int index) to test for attribute existence.
   */ public
 string getPrefixedName(int index) {
    string ret = libsbmlPINVOKE.XMLAttributes_getPrefixedName(swigCPtr, index);
    return ret;
  }

  
/**
   * Return the namespace URI of an attribute in this XMLAttributes set (by position).
   *
   * @param index an integer, the position of the attribute whose namespace URI is 
   * required.
   *
   * @return the namespace URI of an attribute in this list (by position).
   *
   * @note If index is out of range, an empty string will be returned.  Use
   * XMLAttributes::hasAttribute(int index) to test for attribute existence.
   */ public
 string getURI(int index) {
    string ret = libsbmlPINVOKE.XMLAttributes_getURI(swigCPtr, index);
    return ret;
  }

  
/**
   * Return the value of an attribute in this XMLAttributes set (by position).
   *
   * @param index an integer, the position of the attribute whose value is 
   * required.
   *
   * @return the value of an attribute in the list (by position).  
   *
   * @note If index is out of range, an empty string will be returned.  Use
   * XMLAttributes::hasAttribute(int index) to test for attribute existence.
   */ public
 string getValue(int index) {
    string ret = libsbmlPINVOKE.XMLAttributes_getValue__SWIG_0(swigCPtr, index);
    return ret;
  }

  
/**
   * Return an attribute's value by name.
   *
   * @param name a string, the local name of the attribute whose value is required.
   *
   * @return The attribute value as a string.  
   *
   * @note If an attribute with the given local name does not exist, an
   * empty string will be returned.  Use
   * XMLAttributes::hasAttribute(string name, string uri) const
   * to test for attribute existence.  A namespace bound to the local name
   * is not checked by this function.  Thus, if there are multiple
   * attributes with the given local name and different namespaces, the
   * value of an attribute with the smallest index among those attributes
   * will be returned.  XMLAttributes::getValue(string name) or
   * XMLAttributes::getValue(XMLTriple triple) should be used to get a value of an
   * attribute with the given local name and namespace.
   */ public
 string getValue(string name) {
    string ret = libsbmlPINVOKE.XMLAttributes_getValue__SWIG_1(swigCPtr, name);
    return ret;
  }

  
/**
   * Return a value of an attribute with the given local name and namespace URI.
   *
   * @param name a string, the local name of the attribute whose value is required.
   * @param uri  a string, the namespace URI of the attribute.
   *
   * @return The attribute value as a string.  
   *
   * @note If an attribute with the given local name and namespace URI does
   * not exist, an empty string will be returned.  Use
   * XMLAttributes::hasAttribute(string name, string uri) const
   * to test for attribute existence.
   */ public
 string getValue(string name, string uri) {
    string ret = libsbmlPINVOKE.XMLAttributes_getValue__SWIG_2(swigCPtr, name, uri);
    return ret;
  }

  
/**
   * Return a value of an attribute with the given XMLTriple.
   *
   * @param triple an XMLTriple, the XML triple of the attribute whose 
   *        value is required.
   *
   * @return The attribute value as a string.  
   *
   * @note If an attribute with the given XMLTriple does not exist, an
   * empty string will be returned.  Use
   * XMLAttributes::hasAttribute(XMLTriple triple) to test for attribute existence.
   */ public
 string getValue(XMLTriple triple) {
    string ret = libsbmlPINVOKE.XMLAttributes_getValue__SWIG_3(swigCPtr, XMLTriple.getCPtr(triple));
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Predicate returning @c true or @c false depending on whether
   * an attribute with the given index exists in this XMLAttributes.
   *
   * @param index an integer, the position of the attribute.
   *
   * @return @c true if an attribute with the given index exists in this
   * XMLAttributes, @c false otherwise.
   */ public
 bool hasAttribute(int index) {
    bool ret = libsbmlPINVOKE.XMLAttributes_hasAttribute__SWIG_0(swigCPtr, index);
    return ret;
  }

  
/**
   * Predicate returning @c true or @c false depending on whether
   * an attribute with the given local name and namespace URI exists in this 
   * XMLAttributes.
   *
   * @param name a string, the local name of the attribute.
   * @param uri  a string, the namespace URI of the attribute.
   *
   * @return @c true if an attribute with the given local name and namespace 
   * URI exists in this XMLAttributes, @c false otherwise.
   */ public
 bool hasAttribute(string name, string uri) {
    bool ret = libsbmlPINVOKE.XMLAttributes_hasAttribute__SWIG_1(swigCPtr, name, uri);
    return ret;
  }

  
/**
   * Predicate returning @c true or @c false depending on whether
   * an attribute with the given local name and namespace URI exists in this 
   * XMLAttributes.
   *
   * @param name a string, the local name of the attribute.
   * @param uri  a string, the namespace URI of the attribute.
   *
   * @return @c true if an attribute with the given local name and namespace 
   * URI exists in this XMLAttributes, @c false otherwise.
   */ public
 bool hasAttribute(string name) {
    bool ret = libsbmlPINVOKE.XMLAttributes_hasAttribute__SWIG_2(swigCPtr, name);
    return ret;
  }

  
/**
   * Predicate returning @c true or @c false depending on whether
   * an attribute with the given XML triple exists in this XMLAttributes.
   *
   * @param triple an XMLTriple, the XML triple of the attribute 
   *
   * @return @c true if an attribute with the given XML triple exists in this
   * XMLAttributes, @c false otherwise.
   *
   */ public
 bool hasAttribute(XMLTriple triple) {
    bool ret = libsbmlPINVOKE.XMLAttributes_hasAttribute__SWIG_3(swigCPtr, XMLTriple.getCPtr(triple));
    if (libsbmlPINVOKE.SWIGPendingException.Pending) throw libsbmlPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  
/**
   * Predicate returning @c true or @c false depending on whether 
   * this XMLAttributes set is empty.
   * 
   * @return @c true if this XMLAttributes set is empty, @c false otherwise.
   */ public
 bool isEmpty() {
    bool ret = libsbmlPINVOKE.XMLAttributes_isEmpty(swigCPtr);
    return ret;
  }

}

}
